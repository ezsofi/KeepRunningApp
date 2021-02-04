using KeepRunning.Configurations;
using KeepRunning.Database;
using KeepRunning.Services;
using KeepRunning.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KeepRunning
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationDbContext>(builder => builder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSwaggerConfig();
            services.AddScoped<IRunnerService, RunnerService>();
            services.AddScoped<ITrainingPlanService, TrainingPlanService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCustomSwaggerConfig();

            app.UseRouting();
            app.UseStaticFiles();

            app.UseAuthentication();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
