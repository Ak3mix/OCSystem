using GrpcService1.Services;
using OC_System.Contracts;
using OC_System.DataAccess.Repos.RepoEntities;
using OC_System.Contracts;


namespace GrpcService1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Additional configuration is required to successfully run gRPC on macOS.
            // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

            // Add services to the container.
            builder.Services.AddGrpc();
            builder.Services.AddSingleton("Data Source=Data.sqlite");
            builder.Services.AddScoped<IFaseRepository,FaseRepository>();
            builder.Services.AddScoped<IRecetaRepository, RecetaRepository>();
            builder.Services.AddScoped<IOperaracionRepository, OperacionRepository>();
            var app = builder.Build();
           

            // Configure the HTTP request pipeline.
            app.MapGrpcService<FaseService>();
            app.MapGrpcService<RecetaService>();
            app.MapGrpcService<OperacionService>();
            app.MapGrpcService<GreeterService>();
            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}