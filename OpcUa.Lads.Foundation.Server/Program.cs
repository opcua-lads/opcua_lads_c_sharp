using Opc.Ua.Configuration;
using Opc.Ua;
using Serilog;
using System.Net;
using OpcUa.Lads.Foundation.Server;

ApplicationInstance application;
Server server;

// Logger configuration
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();

// Load the server configuration, validate certificates
Configure("LuminescenceReader", 62451);

Log.Information("Starting OPC-UA server (press enter to stop)");
Start();

Console.ReadLine();
Log.Information("Shutting down...");
Stop();


void Configure(string applicationName, int port)
{
    // Create configuration
    var configuration = new ApplicationConfiguration
    {
        ApplicationName = applicationName,
        ApplicationUri = $"urn:{Dns.GetHostName()}:{applicationName}",
        ProductUri = $"uri:opcfoundation.org:{applicationName}",
        ApplicationType = ApplicationType.Server,

        SecurityConfiguration =
        {
            ApplicationCertificate = new CertificateIdentifier
            {
                StoreType = "Directory",
                StorePath = "%LocalApplicationData%/OPC Foundation/pki/own",
                SubjectName = $"CN={applicationName}, C=US, S=Arizona, O=OPC Foundation, DC={Dns.GetHostName()}"
            },
            TrustedIssuerCertificates = new CertificateTrustList
            {
                StoreType = "Directory",
                StorePath = "%LocalApplicationData%/OPC Foundation/pki/issuer"
            },
            TrustedPeerCertificates = new CertificateTrustList
            {
                StoreType = "Directory",
                StorePath = "%LocalApplicationData%/OPC Foundation/pki/trusted"
            },
            RejectedCertificateStore = new CertificateStoreIdentifier
            {
                StoreType = "Directory",
                StorePath = "%LocalApplicationData%/OPC Foundation/pki/rejected"
            },
            AutoAcceptUntrustedCertificates = false,
            RejectSHA1SignedCertificates = true,
            RejectUnknownRevocationStatus = true,
            MinimumCertificateKeySize = 2048,
            AddAppCertToTrustedStore = false,
            SendCertificateChain = true
        },
        ServerConfiguration = new ServerConfiguration
        {
            BaseAddresses =
            [
                $"opc.tcp://{Dns.GetHostName()}:{port}/{applicationName}"
            ],
            SecurityPolicies =
            [
                new ServerSecurityPolicy { SecurityMode = MessageSecurityMode.None, SecurityPolicyUri = "http://opcfoundation.org/UA/SecurityPolicy#None" },
                new ServerSecurityPolicy { SecurityMode = MessageSecurityMode.Sign, SecurityPolicyUri = "" },
                new ServerSecurityPolicy { SecurityMode = MessageSecurityMode.SignAndEncrypt, SecurityPolicyUri = "http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256" }
            ],
            UserTokenPolicies = [new UserTokenPolicy(UserTokenType.Anonymous)],
            MaxRegistrationInterval = 0,
            DiagnosticsEnabled = true
        },
        TransportConfigurations = [],
        TransportQuotas = new TransportQuotas()
    };

    // Validate configuration
    configuration.Validate(ApplicationType.Server).Wait();

    // Create application instance
    application = new ApplicationInstance(configuration)
    {
        ApplicationName = applicationName,
        ApplicationType = ApplicationType.Server,
        CertificatePasswordProvider = new CertificatePasswordProvider("")
    };

    // Check application certificates
    application.CheckApplicationInstanceCertificate(false, CertificateFactory.DefaultKeySize).Wait();
}

void Start()
{
    // Create the server
    server = new Server();
    server.AddNodeManager(new NodeManagerFactory());

    // Start the server
    try
    {
        application.Start(server).Wait();

        // Print notification on session events
        server.CurrentInstance.SessionManager.SessionActivated += (session, reason) => Log.Information($"Session {session.Id} ({session.Identity.DisplayName}) : {reason}");
        server.CurrentInstance.SessionManager.SessionClosing+= (session, reason) => Log.Information($"Session {session.Id} ({session.Identity.DisplayName}) : {reason}");
        server.CurrentInstance.SessionManager.SessionCreated += (session, reason) => Log.Information($"Session {session.Id} ({session.Identity.DisplayName}) : {reason}");
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Unable to start server!");
    }

    // Print endpoint info
    foreach (var endpoint in application.Server.GetEndpoints().Select(e => e.EndpointUrl).Distinct())
    {
        Log.Information(endpoint);
    }
}

void Stop()
{
    server.Stop();
}
