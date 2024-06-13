using Opc.Ua.Server;
using Opc.Ua;

namespace OpcUa.Lads.Foundation.Server
{
    public class NodeManagerFactory : INodeManagerFactory
    {
        public INodeManager Create(IServerInternal server, ApplicationConfiguration configuration)
        {
            return new NodeManager(server, configuration);
        }

        public StringCollection NamespacesUris => [];
    }
}
