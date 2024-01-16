using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

        public App(IConfigurationRoot config) 
        {
            this._config = config;
        }

        public int Run()
        {
            Console.WriteLine($"{_config["appsettings:key"]}");

            return 0;
        }

    }
}
