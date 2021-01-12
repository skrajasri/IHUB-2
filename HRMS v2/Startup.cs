using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HRMS_v2.ViewModel;
using HRMS_v2.Interface;
using HRMS_v2.BussinessLogic;
using CommonLibrary;

namespace HRMS_v2
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
            services.AddControllers();
            CommanConfig.DBConnectionString = Configuration.GetSection("ConnectionStrings").GetSection("HRMS_DB").Value;
            services.AddScoped<IOrganization, Organization>();

            // Get Environment Variable value from appsettings.json
            CommonLibraryConfig.GMailSmtp = Configuration.GetSection("GMail_Configurations").GetSection("GMailSmtp").Value;
            CommonLibraryConfig.Port = int.Parse( Configuration.GetSection("GMail_Configurations").GetSection("GMailSmtpPort").Value); //int.Parse(Environment.GetEnvironmentVariable("GMailSmtpPort"));
            CommonLibraryConfig.GMailID = Configuration.GetSection("GMail_Configurations").GetSection("GMailCredentialName").Value;// Environment.GetEnvironmentVariable("");
            CommonLibraryConfig.Password = Configuration.GetSection("GMail_Configurations").GetSection("GMailCredentialCode").Value; //Environment.GetEnvironmentVariable("");

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
