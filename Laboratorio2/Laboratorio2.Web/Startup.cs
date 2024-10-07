﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Laboratorio2.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public IWebHostEnvironment Env { get; set; }

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Env = env;
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // ES2.1: Injecting appSettings
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            // ES2.2: DECOMMENTARE LA SEGUENTE ISTRUZIONE PER CONFIGURARE LA SESSION
            //services.AddSession();

            var builder = services.AddMvc();
                //.AddSessionStateTempDataProvider(); // ES2.2: CONFIGURA IL TEMPDATA

#if DEBUG
            builder.AddRazorRuntimeCompilation();
#endif

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/Areas/{2}/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Areas/{2}/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Areas/{2}/Views/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");

                options.ViewLocationFormats.Clear();
                options.ViewLocationFormats.Add("/Features/{1}/{0}.cshtml");
                options.ViewLocationFormats.Add("/Features/Views/{1}/{0}.cshtml");
                options.ViewLocationFormats.Add("/Features/Views/Shared/{0}.cshtml");
                options.ViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHsts();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            // ES2.2: DECOMMENTARE LA SEGUENTE ISTRUZIONE PER CONFIGURARE LA SESSION
            //app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                // ES1-ESEMPI: Esempio con mapControllers
                //endpoints.MapControllers();

                // ES1: DECOMMENTARE LE SEGUENTI ISTRUZIONI 1 PER VOLTA PER VERIFICARE
                // ES1-ESEMPI: Esempio con defaults e modificando l'URL in entrata. new { controller = "Pianifica", action = "Tasks" }
                //endpoints.MapControllerRoute("Pianifica", "Pianifica/Tasks"); // ES1-SOLUZIONE: UNICA NON FUNZIONANTE in quanto non sa che cosa chiamare
                //endpoints.MapAreaControllerRoute("pippo", "Pianifica", "Pianifica/{controller}/{action=Index}/{id?}");
                //endpoints.MapAreaControllerRoute("Pianifica", "Pianifica", "Pianifica/{controller=Test}/{action=Index}");
                //endpoints.MapControllerRoute("pluto", "{controller=Login}/{action=Login}/{id?}"); // ES1.1-SOLUZIONE: UNICA NON FUNZIONANTE. In ID ci finisce parte dell'URL

                // ES1.1-ESEMPI: Provare l'URL https://localhost:44373/Pianifica/Tasks/Task/a5d0f931-e48b-476a-9941-1286ca432f3d?id=a5d0f931-e48b-476a-9941-1286ca432f3e e vedere che succede alle 2 route funzionanti.
                // ES1.1-ESEMPI: Spiegare che /id si aspetta l'id nell'url opzionale. Quindi se non lo trova matcha la query string ma se lo trova ignora la query string.

                // ES4: DEFINIRE LE ROTTE PER I VARI CONTROLLERS

                // ES5: DEFINIRE UNA ROTTA PER LE NEWS

                // ES2: DECOMMENTARE LA SEGUENTE ISTRUZIONE
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
