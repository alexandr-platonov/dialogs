using AutoMapper;
using Dialogs.Domain.Interfaces.HookahMixer;
using Dialogs.Domain.Interfaces.KinoRating;
using Dialogs.Domain.Services.HookahMixer;
using Dialogs.Domain.Services.KinoRating;
using Dialogs.Infrastructure.Services;
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
            services.AddScoped<IHookahMixerClient, HookahMixerClient>();
            services.AddScoped<IHookahMixerDialog, HookahMixerDialog>();
            services.AddScoped<ITobaccoRepository, TobaccoRepository>();

            services.AddScoped<IKinoRatingClient, KinoRatingClient>();
            services.AddScoped<IKinoRatingDialog, KinoRatingDialog>();
            services.AddScoped<IKinoRatingApi, OmdbApi>();

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
