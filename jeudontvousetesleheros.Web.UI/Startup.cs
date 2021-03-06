using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontvousetesleheros.Core.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using jeudontvousetesleheros.Core.Data.DataLayer;

namespace jeudontvousetesleheros.Web.UI
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
            services.AddControllersWithViews();


            string connectionString = this.Configuration.GetConnectionString("DefaultContext");

            services.AddTransient<ParagrapheDataLayer, ParagrapheDataLayer>();

            services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
               name: "aventure-edition",
               pattern: "�diter-une-aventure",
               defaults: new { controller = "Aventure", action = "Edit" },
               constraints: new { id = @"\d+" });


                endpoints.MapControllerRoute(
                  name: "aventure-creation",
                  pattern: "demarrer-une-nouvelle-aventure",
                  defaults: new { controller = "Aventure", action = "Create" });


                endpoints.MapControllerRoute(
                  name: "mesaventures",
                  pattern: "mes-aventures",
                  defaults: new { controller = "Aventure", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
