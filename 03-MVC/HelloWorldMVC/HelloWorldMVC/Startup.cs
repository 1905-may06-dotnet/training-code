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
            services.AddMvc();
        }

        //Add Middle wares

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                //This is executed when an error is thrown
                app.UseDeveloperExceptionPage();
            }
            #region MiddleWare Use()
            /* else if (env.IsEnvironment("UAT") || env.IsStaging() || env.IsProduction()) {
                 //CALL TO DIFFERENT MIDDLEWARE
             }
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
             });*/
            #endregion
            // Here it serve the static resources -> from wwwroot folder in the application
            // generally use to load JS files, CSS, jquery
            //app.UseStaticFiles();
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("DevelopmentPage.html");

            //app.UseDefaultFiles(); //looks for index.html/index.htm/default.html/default.htm
            //app.UseDefaultFiles(defaultFilesOptions);
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            
            //used for custom routing and also for attribute based routingd
            app.UseMvc(route=>
            {
                route.MapRoute(
                   name: "default", 
                   template:"{controller=Home}/{action=index}/{id}");
            });
            app.Run(async (context) =>
            {
               // throw new ArgumentException();
                //await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                //await context.Response.WriteAsync(env.EnvironmentName);
                //await context.Response.WriteAsync(configuration["MyOwnKey"]);
                //await context.Response.WriteAsync(" Hello from Middle ware 3"); 
                //await context.Response.WriteAsync("Hello World!!");
                //logger.LogInformation("Middle ware 3: Request has been processed");
                await context.Response.WriteAsync("Request has been processed by app.Run middleware");
                
            });
        }
    }
}
