using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using YuceEgitim.Database;
using YuceEgitim.Services;
using YuceEgitim.Web.Classes;

namespace YuceEgitim.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var MusteriAdi = Configuration.GetSection("Musteri:Adi").Value;

            var musteriOptions = Configuration.GetSection(MusteriOptions.Key).Get<MusteriOptions>();
            services.Configure<MusteriOptions>(Configuration.GetSection(MusteriOptions.Key));

            services.AddDbContext<EgitimDbContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("MyConnection"));


            });
            services.AddScoped<ITicket, Ticket>();
            services.AddSingleton<ICounterService, CounterService>();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting()
                .UseTicket();

            //app.Use(async (context, next) =>
            //{
            //    //herhangi bir şekilde response ya müdahil olmayan islem
            //   // await context.Response.WriteAsync("Merhaba Dünya");
            //    await next.Invoke();
            //    // herhangi bir log islemi

            //});

            //app.Use(async (context, next) =>
            //{
            //    // await context.Response.WriteAsync("Merhaba Dünya");
            //    await next.Invoke();
            //    // ilg girilen yer burası

            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Hello}/{action=Index}/{id?}");
            });
        }
    }
}
