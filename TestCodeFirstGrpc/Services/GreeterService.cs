using System;
using System.Threading.Tasks;
using Common;
using ProtoBuf.Grpc;

namespace TestCodeFirstGrpc.Services
{
    public class GreeterService : IGreeterService
    {
        public GreeterService()
        {
        }

        public Task<HelloReply> SayHelloAsync(HelloRequest request, CallContext context = default)
        {
            return Task.FromResult<HelloReply>(new HelloReply()
            {
                Message = $"Received {request.Name}"
            });
        }
    }
}
