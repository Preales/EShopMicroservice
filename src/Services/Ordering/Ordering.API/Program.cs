using Ordering.API;
using Ordering.Application;
using Ordering.Infraestructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services
          .AddApplicationService()
          .AddInfraestructureService(builder.Configuration)
          .AddApiService();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
