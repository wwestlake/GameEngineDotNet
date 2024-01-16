using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental
{
    public class Startup
    {
        public IConfigurationRoot Configure(ConfigurationBuilder configrurationBuilder) 
        {
            return configrurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public ServiceProvider ConfigureServices(ServiceCollection services, IConfigurationRoot configRoot)
        {
            services.AddSingleton(configRoot);
            services.AddSingleton<App>();
            return services.BuildServiceProvider();
        }

    }
}
