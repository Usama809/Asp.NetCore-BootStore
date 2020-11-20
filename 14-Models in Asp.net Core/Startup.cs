using _14_Models_in_Asp.net_Core.Data;
using _14_Models_in_Asp.net_Core.Repositores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
namespace _14_Models_in_Asp.net_Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            DbContextOptionsBuilder<BookStoreContext> options = new DbContextOptionsBuilder<BookStoreContext>();
            options.UseSqlServer(Configuration.GetConnectionString("myconn"));
            services.AddDbContext<BookStoreContext>(
                  options => options.UseSqlServer(
                      Configuration.GetConnectionString("myconn"),
                      b => b.MigrationsAssembly(typeof(BookStoreContext).Assembly.FullName)));


            //services.AddRazorPages();
            //services.AddServerSideBlazor();
           services.AddControllersWithViews();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();

                //uncomment When disable clint side validation
               //.AddViewOptions(option =>
           // {
              // option.HtmlHelperOptions.ClientValidationEnabled = false;
           // });
#endif
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();


        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapControllers();
            //    endpoints.MapRazorPages();
            //    endpoints.MapBlazorHub();
            //});
            

            app.UseEndpoints(endpoints =>
            {
               endpoints.MapDefaultControllerRoute();
            ////    //endpoints.MapControllerRoute(
            ////    //   name: "Default",
            ////    //  pattern:"{controller}/{action}/{id?}");

            ////    //Conventional Routing
            ////    //endpoints.MapControllerRoute(
            ////    //   name: "About us",
            ////    //   pattern: "about-us",
            ////    //  defaults : new { controller ="Home" , action ="AboutUs"});


            });
        }
    }
}
