using API;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder
    .Services
    .AddSingleton(ConnectionMultiplexer.Connect(configuration.GetConnectionString("Redis") ?? string.Empty))
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .InitializeOnStartup()
    .PublishSchemaDefinition(config => config
                                        .SetName("Notes")
                                        .PublishToRedis("Snippr", factory => factory.GetRequiredService<ConnectionMultiplexer>()));

var app = builder.Build();
app.MapGraphQL();
app.Run();
