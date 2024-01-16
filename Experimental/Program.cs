using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Experimental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            var startup = new Startup();
            var config = startup.Configure(new ConfigurationBuilder());
            var serviceProvider = startup.ConfigureServices(services, config);

            var app = serviceProvider.GetRequiredService<App>();
            app.Run();
        }
    }
}
