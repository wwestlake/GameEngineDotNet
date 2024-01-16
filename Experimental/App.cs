using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental
{
    public class App
    {
        private readonly IConfigurationRoot _config;
        private readonly ILogger<App> _logger;

        public App(IConfigurationRoot config, ILogger<App> logger) 
        {
            this._config = config;
            this._logger = logger;
        }

        public int Run()
        {
            _logger.LogInformation("Starting application.");


            _logger.LogInformation("Shutting down application.");
            return 0;
        }

    }
}
