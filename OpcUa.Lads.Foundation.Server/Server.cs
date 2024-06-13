using Opc.Ua;
using Opc.Ua.Server;

namespace OpcUa.Lads.Foundation.Server
{
    public class Server : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            server.Factory.AddEncodeableTypes(GetType().Assembly);
            return base.CreateMasterNodeManager(server, configuration);
        }
    }
}
