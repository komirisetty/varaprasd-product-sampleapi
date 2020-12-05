using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellFargo.Libraries.DataAccess.Impl;
using WellsFargo.Libraries.DataAccess.Interfaces;
using WellsFargo.Libraries.Domain.Interfaces;
using WellsFargo.Libraries.Domian.Impl;
using WellsFargo.Libraries.Hosting.Extensibility;
using WellsFargo.Libraries.ORM.Impl;
using WellsFargo.Libraries.ORM.Interfaces;

namespace ProductsREST_Hosting
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

         
            services.AddScoped<IProductsContext, ProductsContext>();
            services.AddScoped<IProductsRepositories, ProductsRepositories>();
            services.AddScoped<IProductsDomainService, ProductsDomainService>();         
            services.AddScoped<IProductsDatabaseSettings, ProductDatabaseSettings>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
