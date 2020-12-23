using AutoMapper;
using Dialogs.Domain.Interfaces.HookahMixer;
using Dialogs.Domain.Services;
using Dialogs.Infrastructure;
using Dialogs.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace Dialogs
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

            ConfigureAppServices(services);
        }

        public void ConfigureAppServices(IServiceCollection services)
        {
            services.AddScoped<IHookahMixerDialog, HookahMixerDialog>();
            services.AddScoped<ITobaccoRepository, TobaccoRepository>();
            services.AddScoped<IHookahMixerClient, HookahMixerClient>();

            services.AddAutoMapper(typeof(ViewModelsMappingProfile));
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
