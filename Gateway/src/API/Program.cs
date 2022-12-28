using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddCors();

builder.Services.AddHttpClient("Notes", config => config.BaseAddress = new Uri(configuration["Subgraphs:Notes"] ?? string.Empty));
builder.Services.AddHttpClient("Users", config => config.BaseAddress = new Uri(configuration["Subgraphs:Users"] ?? string.Empty));

builder
    .Services
    .AddSingleton(ConnectionMultiplexer.Connect(configuration.GetConnectionString("Redis") ?? string.Empty))
    .AddGraphQLServer()
    .AddRemoteSchemasFromRedis("Snippr", factory => factory.GetRequiredService<ConnectionMultiplexer>());

var app = builder.Build();
app.UseCors(config => config.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.MapGraphQL();
app.Run();
