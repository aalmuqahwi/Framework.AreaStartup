using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaStartup
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseAreaStartup(this IApplicationBuilder app)
        {
            var applicationServices = app.ApplicationServices;

            //getting all registered IAreaStartup.
            var startups = applicationServices.GetServices<IAreaStartup>();
            var env = applicationServices.GetService<IHostingEnvironment>();

            foreach (var startup in startups)
            {
                startup.Configure(app, env);
            }

            return app;
        }
    }
}
