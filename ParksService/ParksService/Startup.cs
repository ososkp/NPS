using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using ParksService.Data.Abstract;
using ParksService.Data.Abstract.Repositories;
using ParksService.Data.Concrete;
using ParksService.Data.Concrete.Repositories;
using ParksService.Services.Abstract;
using ParksService.Services.Concrete;

namespace ParksService
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            /*
			My service Configurations
			*/
            services.AddScoped<IParkService, ParkService>();
            services.AddScoped<IParkRepository, ParkRepository>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEntranceFeeRepository, EntranceFeeRepository>();
            services.AddScoped<IEntranceFeeService, EntranceFeeService>();
            //	        services.AddScoped<IImageDataRepository, ImageDataRepository>();
            //	        services.AddScoped<IImageDataService, ImageDataService>();
            //			services.AddScoped<IOperatingHoursRepository, OperatingHoursRepository>();
            //	        services.AddScoped<IOperatingHoursService, OperatingHoursService>();
            //	        services.AddScoped<IHoursExceptionsRepository, HoursExceptionsRepository>();
            //	        services.AddScoped<IHoursExceptionsService, HoursExceptionsService>();
            //	        services.AddScoped<IWeeklyHoursRepository, WeeklyHoursRepository>();
            //	        services.AddScoped<IWeeklyHoursService, WeeklyHoursService>();

            services.AddAutoMapper();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //	        .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
