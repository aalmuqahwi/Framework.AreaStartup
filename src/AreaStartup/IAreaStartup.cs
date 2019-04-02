using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AreaStartup
{
    public interface IAreaStartup
    {
        void ConfigureServices(IServiceCollection services);
        void Configure(IApplicationBuilder app, IHostingEnvironment env);
    }
}
