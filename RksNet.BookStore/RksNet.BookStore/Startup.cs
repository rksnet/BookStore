using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RksNet.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    //if (env.IsDevelopment())
                    //{
                    //    await context.Response.WriteAsync("Developemnt");
                    //}
                    //else if (env.IsProduction())
                    //{
                    //    await context.Response.WriteAsync("Production");
                    //}
                    //else if(env.IsEnvironment("QA Environment"))
                    //{
                    //    await context.Response.WriteAsync("QA Environment");
                    //}
                    await context.Response.WriteAsync("Hello World!");
                });
            });*/

            /*
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from first middleware request\n\n");
                await next();
                await context.Response.WriteAsync("Hello from first middleware response\n\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from second middleware request\n\n");
                await next();
                await context.Response.WriteAsync("Hello from second middleware response\n\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from third middleware request\n\n");
            });
            */
        }
    }
}
