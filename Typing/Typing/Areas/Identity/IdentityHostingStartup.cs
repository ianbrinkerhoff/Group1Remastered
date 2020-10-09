using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Typing.Data;

[assembly: HostingStartup(typeof(Typing.Areas.Identity.IdentityHostingStartup))]
namespace Typing.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TypingContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TypingContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                  //  .AddEntityFrameworkStores<TypingContext>();
            });
        }
    }
}