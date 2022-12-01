
using Opc.Ua;
using Opc.Ua.Server;
using OpcUAServer.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
//using InfeedClient;

namespace OPCUAServer
{
    public class InfeedNodeManager : CustomNodeManager2
    {
        VehicleState m_MojVozen;
        Timer m_simulationTimer;


        public InfeedNodeManager(IServerInternal server, params string[] namespaceUris ) : base(server, namespaceUris)
        {

        }

        /// <summary>
        /// This constructor is called from server CreateMasterNodeManager method.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="configuration"></param>
        public InfeedNodeManager(IServerInternal server, ApplicationConfiguration configuration)  //: base(server, configuration, configuration.ProductUri)
            : base(server, configuration, OPCUAServer.Namespaces.OPCUAServer)
        {
            SystemContext.NodeIdFactory = this;
        }
        /// <summary>
        /// Loading predefined nodes from the information model
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();

            predefinedNodes.LoadFromBinaryResource(context,
                "Model/OpcUAServer.Asset.PredefinedNodes.uanodes",
                typeof(InfeedNodeManager).GetTypeInfo().Assembly,
                true);

            
            return predefinedNodes;
            //return base.LoadPredefinedNodes(context);
        }

        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        /// <remarks>
        /// The externalReferences is an out parameter that allows the node manager to link to nodes
        /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
        /// should have a reference to the root folder node(s) exposed by this node manager.  
        /// </remarks>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // find the untyped Boiler1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(OpcUAServer.Asset.Objects.MojVozen01, NamespaceIndexes[0]), typeof(BaseObjectState));

                // convert the untyped node to a typed node that can be manipulated within the server.
                m_MojVozen = new VehicleState(null);
                m_MojVozen.Create(SystemContext, passiveNode);

                // replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, m_MojVozen);

                // set up method handlers. 
                m_MojVozen.DoService.OnCallMethod = new GenericMethodCalledEventHandler(OnDoService);

                // start a simulation that changes the values of the nodes.
                m_simulationTimer = new Timer(DoSimulation, null, 1000, 1000);
            }
        }


        private void DoSimulation(object state)
        {
            try
            {
                lock (Lock)
                {

                    // get the difference between Now UTC and lastServiced in minutes
                    TimeSpan diff = DateTime.UtcNow - m_MojVozen.LastServiced.Value;

                    if (m_MojVozen.LifeTime.Value >= diff.TotalMinutes)
                    {
                        float health = ((float)m_MojVozen.LifeTime.Value - (float)(diff.TotalMinutes)) / (float)m_MojVozen.LifeTime.Value;
                        m_MojVozen.Health.Value = (int)Math.Round(health * 100.0);
                    }
                    else
                        m_MojVozen.Health.Value = 0;


                    m_MojVozen.ClearChangeMasks(SystemContext, true);
                }
            }
            catch (Exception e)
            {
                Utils.Trace(e, "Unexpected error during simulation.");
            }
        }

        public ServiceResult OnDoService(
            ISystemContext context,
            MethodState method,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            // all arguments must be provided.
            if (inputArguments.Count != 0)
            {
                return StatusCodes.BadArgumentsMissing;
            }

            // signal update to state node.
            lock (Lock)
            {
                m_MojVozen.LastServiced.Value = DateTime.UtcNow;
                m_MojVozen.ClearChangeMasks(SystemContext, true);
            }

            return ServiceResult.Good;
        }


    }
}
