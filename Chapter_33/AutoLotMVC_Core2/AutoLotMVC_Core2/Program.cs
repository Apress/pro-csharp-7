using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoLotDAL_Core2.DataInitialization;
using AutoLotDAL_Core2.EF;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AutoLotMVC_Core2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = BuildWebHost(args);
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<AutoLotContext>();
                MyDataInitializer.RecreateDatabase(context);
                MyDataInitializer.InitializeData(context);
            }
            webHost.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseUrls("http://*:60001")
                .UseStartup<Startup>()
                .Build();

        //public static IWebHostBuilder CreateDefaultBuilder(string[] args)
        //{
        //    return new WebHostBuilder()
        //        .UseKestrel()
        //        .UseContentRoot(Directory.GetCurrentDirectory())
        //        .ConfigureAppConfiguration(
        //            (Action<WebHostBuilderContext, IConfigurationBuilder>) ((hostingContext, config) =>
        //            {
        //                IHostingEnvironment hostingEnvironment = hostingContext.HostingEnvironment;
        //                config.AddJsonFile("appsettings.json", true, true).AddJsonFile(
        //                    string.Format("appsettings.{0}.json", 
        //                    (object) hostingEnvironment.EnvironmentName), 
        //                    true,
        //                    true);
        //                if (hostingEnvironment.IsDevelopment())
        //                {
        //                    Assembly assembly = Assembly.Load(new AssemblyName(hostingEnvironment.ApplicationName));
        //                    if (assembly != (Assembly) null)
        //                        config.AddUserSecrets(assembly, true);
        //                }
        //                config.AddEnvironmentVariables();
        //                if (args == null)
        //                    return;
        //                config.AddCommandLine(args);
        //            }))
        //            .ConfigureLogging((Action<WebHostBuilderContext, ILoggingBuilder>) ((hostingContext, logging) =>
        //        {
        //            logging.AddConfiguration((IConfiguration) hostingContext.Configuration.GetSection("Logging"));
        //            logging.AddConsole();
        //            logging.AddDebug();
        //        }))
        //        .UseIISIntegration()
        //        .UseDefaultServiceProvider((Action<WebHostBuilderContext, ServiceProviderOptions>) 
        //        ((context, options) => options.ValidateScopes = context.HostingEnvironment.IsDevelopment()));
        //}
    }
}