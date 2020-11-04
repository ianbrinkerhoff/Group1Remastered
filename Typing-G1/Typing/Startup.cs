using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Typing.Hubs;
using Microsoft.EntityFrameworkCore;
using Typing.DataAccess.Data;
using Typing.DataAccess.Data.Repository.IRepository;
using Typing.DataAccess.Data.Repository;

namespace Typing
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSignalR();

            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ApplicationDbContext"),
                    sqlServerOptions => sqlServerOptions.MigrationsAssembly("Typing.DataAccess")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();//scoping the service 1 time per every client connection

            //uncomment for being able to manipulate whole database localy.
            //the reason is to use API calls and program things through java on the client base
            //services.AddMvc(Options => Options.EnableEndpointRouting = false);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //uncomment for being able to manipulate whole database localy.
            //the reason is to use API calls and program things through java on the client base
            //app.UseMvc();

            //comment this out to use the Mvc routing 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapHub<MessageHub>("/messagehub");
            });
        }
    }
}
