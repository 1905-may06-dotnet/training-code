using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloWorldMVC
{
    public class Startup
    {
        private IConfiguration configuration;
        public Startup(IConfiguration Configuration)
        {
            configuration = Configuration;
        }
        //Add Dependency -> 

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        //Add Middle wares

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILogger<Startup> logger)
        {
            /*if (env.IsDevelopment())
            {
                //This is executed when an error is thrown
                app.UseDeveloperExceptionPage();
            }*/
            app.Use(async (context,next) => {
                logger.LogInformation("Middleware 1: incoming request");
                //await context.Response.WriteAsync("Hello from Middle ware 1");
                await next();
                logger.LogInformation("Middleware 1: outgoing response");
            });
            app.Use(async (context, next) => {
                logger.LogInformation("Middle ware 2: incoming request");
                //await context.Response.WriteAsync("Hello from Middle ware 2 ");
                await next();
                logger.LogInformation("Middleware 2: outgoing response");
            });
            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                //await context.Response.WriteAsync(env.EnvironmentName);
                //await context.Response.WriteAsync(configuration["MyOwnKey"]);
                //await context.Response.WriteAsync(" Hello from Middle ware 3");
                logger.LogInformation("Middle ware 3: Request has been processed");
                await context.Response.WriteAsync("Hello World!!");
            });
        }
    }
}
