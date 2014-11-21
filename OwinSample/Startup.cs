using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OwinSample.Startup))]

namespace OwinSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage(new Microsoft.Owin.Diagnostics.WelcomePageOptions()
            {
                Path = new PathString("/welcome")
            });

            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";

                string output = string.Format(
                    "I'm running on {0} \nFrom assembly {1}", 
                    Environment.OSVersion, 
                    System.Reflection.Assembly.GetEntryAssembly().FullName
                    );

                return context.Response.WriteAsync(output);

            });
        }
    }
}
