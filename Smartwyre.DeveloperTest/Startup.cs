using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Configuration;
using Smartwyre.DeveloperTest.Entities;

namespace Smartwyre.DeveloperTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<ConnectionStringsSection>(Configuration.GetSection("ConnectionStrings"));
            services.AddDbContext<ApplicationDBContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DBConnString")));

        }

    }
}