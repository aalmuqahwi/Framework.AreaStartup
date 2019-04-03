using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace AreaStartup
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAreaStartup<TStartup>(this IServiceCollection services)
        {
            //getting all classes that implement IAreaStartup interface.
            var types = typeof(TStartup)
                .Assembly
                .GetTypes()
                .Where(e => typeof(IAreaStartup).IsAssignableFrom(e))
                .ToList();

            //register all types into the container.
            foreach (var type in types)
            {
                if((type != null) && (type != typeof(IAreaStartup)))
                {
                    services.AddSingleton(typeof(IAreaStartup), type);
                }
            }

            var serviceProvider = services.BuildServiceProvider();
            var startups = serviceProvider.GetServices<IAreaStartup>();
            foreach (var startup in startups)
            {
                startup.ConfigureServices(services);
            }

            return services;
        }
    }
}
