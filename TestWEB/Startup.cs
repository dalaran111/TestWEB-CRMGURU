using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using TestWeb.Domain.Concrete;
using TestWeb.Domain.InterfaciesAbstract;


namespace TestWEB
{  
    /// <summary>
     /// The application starts with it. That is, this is the entry point to the application.
     /// </summary>
    public class Startup

    {    /// <summary>
         /// Ñonstructor for startup class
         /// </summary>
         /// <param name="configuration"> Interface of configuration </param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// Interface of configuration
        /// </summary>
        public IConfiguration Configuration { get; }
        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"> Interface of service collection </param>

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Use default connection
            string connection = Configuration.GetConnectionString("DefaultConnection");
            // Dependency Injection
            services.AddTransient<CityRepository, ConcreteCityRepository>(provider => new ConcreteCityRepository(connection));
            services.AddTransient<CountryRepository, ConcreteCountryRepository>(provider => new ConcreteCountryRepository(connection));
            services.AddTransient<RegionRepository, RegionRepository>(provider => new ConcreteRegionRepository(connection));
            services.AddControllersWithViews();
            services.AddMvc();

        }


        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"> Interface of application builder </param>
        /// <param name="env"> Interface of web host environment </param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseRequestLocalization();
            var cultureInfo = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
