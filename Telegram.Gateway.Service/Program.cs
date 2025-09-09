using Telegram.Gateway.Application;
using Telegram.Gateway.Domain;
using Telegram.Gateway.Infrastructure;
using Telegram.Gateway.Service;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddDomainServices()
                .AddInfrastructureServices()
                .AddApplicationServices()
                .AddServiceServices(builder.Configuration);

IHost host = builder.Build();
host.Run();
