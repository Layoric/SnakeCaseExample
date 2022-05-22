using Funq;
using ServiceStack;
using ServiceStack.Text;
using SnakeCaseExample.ServiceInterface;

[assembly: HostingStartup(typeof(SnakeCaseExample.AppHost))]

namespace SnakeCaseExample;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("SnakeCaseExample", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(new HostConfig {
            UseSameSiteCookies = true
        });

        JsConfig.Init(new Config
        {
            TextCase = TextCase.SnakeCase
        });
    }
}
