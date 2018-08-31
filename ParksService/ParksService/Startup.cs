using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
                app.UseHsts(
//	                hsts => hsts.MaxAge(365).IncludeSubdomains()
	                );
            }

//			// Added security from NWebSec
//			// See https://damienbod.com/2018/02/08/adding-http-headers-to-improve-security-in-an-asp-net-mvc-core-application/
//
//			// Add the X-Content-Type-Options Header
//			// The X-Content-Type-Options can be set to no-sniff to prevent content sniffing.
//			app.UseXContentTypeOptions();
//			// Add the Referrer Policy Header
//			// This allows us to restrict the amount of information being passed on to other sites when referring to other sites. This is set to no referrer.
//			app.UseReferrerPolicy(opts => opts.NoReferrer());
//
//			// Add the X-XSS-Protection Header
//	        // The HTTP X - XSS - Protection response header is a feature of Internet Explorer,
//	        // Chrome and Safari that stops pages from loading when they detect reflected
//	        // cross - site scripting(XSS) attacks.
//	        app.UseXXssProtection(options => options.EnabledWithBlockMode());
//
//			// Add the X-Frame-Options Header
//			// You can use the X-frame-options Header to block iframes and prevent click jacking attacks.
//	        app.UseXfo(options => options.Deny());
//
//			// Add the Content-Security-Policy Header
//			// Content Security Policy can be used to prevent all sort of attacks, XSS, click-jacking attacks,
//			// or prevent mixed mode (HTTPS and HTTP). The following configuration works for ASP.NET Core MVC applications,
//			// the mixed mode is activated, styles can be read from unsafe inline, due to the razor controls, or tag helpers,
//			// and everything can only be loaded from the same origin.
//	        app.UseCsp(opts => opts
//		        .BlockAllMixedContent()
//		        .FormActions(s => s.Self()));

			app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Directory}/{id?}");
            });
        }
    }
}
