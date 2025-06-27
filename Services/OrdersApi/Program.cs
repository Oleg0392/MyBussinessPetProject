using Carter;
using Mapster;
using MediatR;
using OrdersApi;
using OrdersInfrastructure;
using OrdersInfrastructure.Data.Extensions;

namespace OrdersApi
{
    public class Program
    {
        public static async void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
                .AddApplicationServices(builder.Configuration)
                .AddInfrastructureServices(builder.Configuration)
                .AddApiServices(builder.Configuration);

            var app = builder.Build();

            app.UseApiServices();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                await app.InitialiseDatabaseAsync();
            }

            app.Run();
        }
    }
}
