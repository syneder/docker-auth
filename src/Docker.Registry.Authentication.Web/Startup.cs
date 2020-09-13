using Docker.Registry.Authentication.Web.Internal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Docker.Registry.Authentication.Web
{
    /// <summary>
    /// This class configures services and the app's request pipeline.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configuring additional services for the host or web application.
        /// </summary>
        /// <param name="services">A collection of service descriptors.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(BasicAuthenticationDefaults.AuthenticationScheme).AddBasic();
        }

        /// <summary>
        /// Configuring the HTTP request pipeline.
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    Console.WriteLine(context.Request.GetEncodedUrl());
                    Console.WriteLine("Remote IP: " + context.Connection.RemoteIpAddress);
                    Console.WriteLine("User is authenticated: " + context.User.Identity.IsAuthenticated);
                    Console.WriteLine("User name: " + context.User.Identity.Name);

                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
