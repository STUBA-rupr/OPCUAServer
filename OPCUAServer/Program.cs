using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCUAServer
{
    internal class Program
    {
        public enum ExitCode : int
        {
            Ok = 0,
            ErrorServerNotStarted = 0x80,
            ErrorServerRunning = 0x81,
            ErrorServerException = 0x82,
            ErrorInvalidCommandLine = 0x100
        };

        static int Main(string[] args)
        {
            bool autoAccept = true;
            int stopTimeout = 0;
            
            MySampleServer server = new MySampleServer(autoAccept, stopTimeout, null);
            server.Run();

            return (int)MySampleServer.ExitCode;
        }

        public class MySampleServer
        {
            public SampleServer Server { get; private set; }
            public Task Status { get; private set; }
            public DateTime LastEventTime { get; private set; }
            public int ServerRunTime { get; private set; } = Timeout.Infinite;
            public static bool AutoAccept { get; private set; }
            public static ExitCode ExitCode { get; private set; }
            public Uri ReverseConnectUrl { get; private set; }

            public MySampleServer(bool _autoAccept, int _stopTimeout)
                : this(_autoAccept, _stopTimeout, null)
            {
            }

            public MySampleServer(bool _autoAccept, int _stopTimeout, Uri _reverseConnectUrl)
            {
                AutoAccept = _autoAccept;
                ServerRunTime = _stopTimeout == 0 ? Timeout.Infinite : _stopTimeout * 1000;
                ReverseConnectUrl = _reverseConnectUrl;
            }

            public void Run()
            {

                try
                {
                    ExitCode = ExitCode.ErrorServerNotStarted;
                    ConsoleSampleServer().Wait();
                    Console.WriteLine("Server started. Press Ctrl-C to exit...");
                    ExitCode = ExitCode.ErrorServerRunning;
                }
                catch (Exception ex)
                {
                    Utils.Trace("ServiceResultException:" + ex.Message);
                    Console.WriteLine("Exception: {0}", ex.Message);
                    ExitCode = ExitCode.ErrorServerException;
                    return;
                }

                ManualResetEvent quitEvent = new ManualResetEvent(false);
                try
                {
                    Console.CancelKeyPress += (sender, eArgs) => {
                        quitEvent.Set();
                        eArgs.Cancel = true;
                    };
                }
                catch
                {
                }

                // wait for timeout or Ctrl-C
                quitEvent.WaitOne(ServerRunTime);

                if (Server != null)
                {
                    Console.WriteLine("Server stopped. Waiting for exit...");

                    using (SampleServer _server = Server)
                    {
                        Server.CurrentInstance.SessionManager.SessionActivated -= EventStatus;
                        Server.CurrentInstance.SessionManager.SessionClosing -= EventStatus;
                        Server.CurrentInstance.SessionManager.SessionCreated -= EventStatus;

                        // Stop status thread
                        Server = null;
                        Status.Wait();
                        // Stop server and dispose
                        _server.Stop();
                    }
                }

                ExitCode = ExitCode.Ok;
            }

            private static void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
            {
                if (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted)
                {
                    e.Accept = AutoAccept;
                    if (AutoAccept)
                    {
                        Console.WriteLine("Accepted Certificate: {0}", e.Certificate.Subject);
                    }
                    else
                    {
                        Console.WriteLine("Rejected Certificate: {0}", e.Certificate.Subject);
                    }
                }
            }

            private async Task ConsoleSampleServer()
            {
                //ApplicationInstance.MessageDlg = new ApplicationMessageDlg();
                ApplicationInstance application = new ApplicationInstance();

                application.ApplicationName = "InfeedServerPLC";
                application.ApplicationType = ApplicationType.Server;
                application.ConfigSectionName = "InfeedServerPLC";

                // load the application configuration.
                ApplicationConfiguration config = await application.LoadApplicationConfiguration(false);

                // check the application certificate.
                bool haveAppCertificate = await application.CheckApplicationInstanceCertificate(false, 0);
                if (!haveAppCertificate)
                {
                    throw new Exception("Application instance certificate invalid!");
                }

                if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
                }

                // start the server.
                Server = new SampleServer();
                await application.Start(Server);

                if (ReverseConnectUrl != null)
                {
                    Server.AddReverseConnection(ReverseConnectUrl);
                }

                var reverseConnections = Server.GetReverseConnections();
                if (reverseConnections?.Count > 0)
                {
                    // print reverse connect info
                    Console.WriteLine("Reverse Connect Clients:");
                    foreach (var connection in reverseConnections)
                    {
                        Console.WriteLine(connection.Key);
                    }
                }

                // print endpoint info
                Console.WriteLine("Server Endpoints:");
                var endpoints = Server.GetEndpoints().Select(e => e.EndpointUrl).Distinct();
                foreach (var endpoint in endpoints)
                {
                    Console.WriteLine(endpoint);
                }

                // start the status thread
                Status = Task.Run(new Action(StatusThread));

                // print notification on session events
                Server.CurrentInstance.SessionManager.SessionActivated += EventStatus;
                Server.CurrentInstance.SessionManager.SessionClosing += EventStatus;
                Server.CurrentInstance.SessionManager.SessionCreated += EventStatus;

            }

            private void EventStatus(Session session, SessionEventReason reason)
            {
                LastEventTime = DateTime.UtcNow;
                PrintSessionStatus(session, reason.ToString());
            }

            void PrintSessionStatus(Session session, string reason, bool lastContact = false)
            {
                lock (session.DiagnosticsLock)
                {
                    string item = String.Format("{0,9}:{1,20}:", reason, session.SessionDiagnostics.SessionName);
                    if (lastContact)
                    {
                        item += String.Format("Last Event:{0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime());
                    }
                    else
                    {
                        if (session.Identity != null)
                        {
                            item += String.Format(":{0,20}", session.Identity.DisplayName);
                        }
                        item += String.Format(":{0}", session.Id);
                    }
                    Console.WriteLine(item);
                }
            }

            private async void StatusThread()
            {
                while (Server != null)
                {
                    if (DateTime.UtcNow - LastEventTime > TimeSpan.FromMilliseconds(6000))
                    {
                        IList<Session> sessions = Server.CurrentInstance.SessionManager.GetSessions();
                        for (int ii = 0; ii < sessions.Count; ii++)
                        {
                            Session session = sessions[ii];
                            PrintSessionStatus(session, "-Status-", true);
                        }
                        LastEventTime = DateTime.UtcNow;
                    }
                    await Task.Delay(1000);
                }
            }
        }

    }
}
