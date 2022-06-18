using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use 1\n");
            //    await next();

            //    await context.Response.WriteAsync("Hello from Use 2\n");
            //});

            //app.UseMiddleware<CustomMiddleware1>();

            //app.Map("/can", CustomCode);

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use 3\n");
            //    await next();

            //    await context.Response.WriteAsync("Hello from Use 4\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request completed\n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run \n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run2");
            //});



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello from new Web API app");
                //});

                //endpoints.MapGet("/test", async context =>
                //{
                //    await context.Response.WriteAsync("Hello from new Web API app test");
                //});

                endpoints.MapControllers();
            });
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Can\n");
            });
        }
    }
}
