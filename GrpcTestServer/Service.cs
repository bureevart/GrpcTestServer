using Grpc.Core;

namespace GrpcTestServer;

public class Service : Greeter.GreeterBase
{
    private readonly ILogger<Service> _logger;

    public Service(ILogger<Service> logger)
    {
        _logger = logger;
    }
    
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply()
        {
            Message = $"Hello {request.Name}"
        });
    }
}