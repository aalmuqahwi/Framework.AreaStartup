using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AreaStartup;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AreaStartup.Sample.Areas.Profile
{
    public class AreaStartup : IAreaStartup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //add any dependencies to this area.
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
        }
    }
}
