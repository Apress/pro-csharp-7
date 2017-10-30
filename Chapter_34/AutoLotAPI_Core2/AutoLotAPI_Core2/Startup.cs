using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoLotAPI_Core2.Filters;
using AutoLotDAL_Core2.EF;
using AutoLotDAL_Core2.Repos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace AutoLotAPI_Core2
{
    public class Startup
    {
        private readonly IHostingEnvironment _env;
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            _env = env;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(config =>
                {
                    config.Filters.Add(new AutoLotExceptionFilter(_env));
                })
                .AddJsonOptions(options =>
                {
                    //Revert to PascalCasing for JSON handling
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });
            services.AddDbContextPool<AutoLotContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("AutoLot"),
                        o => o.EnableRetryOnFailure())
                    .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning)));
            services.AddScoped<IInventoryRepo, InventoryRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}