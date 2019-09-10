using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace mvc_core_movie_app
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //bunu sonradan ekledik mvcyi projeye dahil etmek için
            services.AddMvc()
            .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //bu metod ile wwwroot klasörünün içindeki tüm klasör ve dosyalar dışarıya açılır
            //wwwroot otomatik olarak -> /css/style.css /img/1.jpg olarak linkleri düzenler
            app.UseStaticFiles();


            //bu metodu açmamızın sebebi wwwroot özel bir klasörken node_modules öyle değil
            //o nedenle node_modules klasörünü de dışarıya açmamız için bu metodu kullandık
            // modules/bootstrap/dist/css/bootstrap.min.css şeklinde bir urle dönüşür
            // app.UseStaticFiles(new StaticFileOptions
            // {

            //     FileProvider = new PhysicalFileProvider(Path.Combine
            //     (Directory.GetCurrentDirectory(), "node_moduls")),
            //     //burada urlde node_modulesi kullanmamak için modules takma adını verdik
            //     RequestPath = "/modules"

            // });

            //eğer env(.vscode içerisindeki launch.jsonda var) developmentsa hataları detaylı 
            //bir şekilde göster
            //projeyi publice açtığımızda launch.jsonda yazan Development kısmını
            //Production'a çevirmemiz lazım ki kullanıcılar hataları görmesin
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // home/index/3
            app.UseMvcWithDefaultRoute();
        }
    }
}
