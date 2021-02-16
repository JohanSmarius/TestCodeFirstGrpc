using System;
using System.Threading.Tasks;
using Common;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;

namespace GreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;

            using var channel = GrpcChannel.ForAddress("https://localhost:5001/");

            var greeterService = channel.CreateGrpcService<IGreeterService>();

            var result = await greeterService.SayHelloAsync(new HelloRequest { Name = "Hello from code first" } );

            Console.WriteLine(result.Message);
;
        }
    }
}
