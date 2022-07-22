using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Prestadores_Identity.Areas.Identity.IdentityHostingStartup))]
namespace Prestadores_Identity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}