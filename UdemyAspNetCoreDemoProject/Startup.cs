using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UdemyAspNetCoreDemoProject.Models;
using UdemyAspNetCoreDemoProject.Services;

namespace UdemyAspNetCoreDemoProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<ICalculator, Calculator8>();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=SchoolDb;Trusted_Connection=true";
            services.AddDbContext<SchoolContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name:"default",
                    //istek controller/index/id şeklinde yapılmalı.(id opsiyonel)
                    template: "{controller=home}/{action=index}/{id?}"
                    );
            });
        }
    }
}
