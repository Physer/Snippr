using Application;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyRegistrator
{
    public static void RegisterInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddHttpClient<INoteRepository, NoteRepository>();
    }
}
