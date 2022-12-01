
using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using InfeedClient;

namespace OPCUAServer
{
    public class InfeedNodeManager : CustomNodeManager2
    {
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
   
    }
}
