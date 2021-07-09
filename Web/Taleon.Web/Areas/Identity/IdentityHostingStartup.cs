using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Taleon.Web.Areas.Identity.IdentityHostingStartup))]

namespace Taleon.Web.Areas.Identity
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