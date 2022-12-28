using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Client;

public static class DependencyRegistrator
{
    public static void RegisterClientDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddGatewayClient().ConfigureHttpClient(client => client.BaseAddress = new Uri(configuration["SnipprApiUrl"] ?? string.Empty));
    }
}
