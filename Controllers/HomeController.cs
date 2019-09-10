using Microsoft.AspNetCore.Mvc;

namespace mvc_core_movie_app.Controllers
{
    public class HomeController:Controller
    {
        //terminal -> npm init --yes ile package.json dosyasını otomatik projeye ekledi
        //package.jsonu eklememizin sebebi eklediğimiz tüm packageleri (örn bootstrap) kendi otomatik
        //dahil eder ve örn node_moduls klasörünü sildik. Terminale npm install dediğimizde package.jsonda
        //yazılan tüm packageleri tekrar ekler ve node_moduls klasörü geri gelir
        // npm i bootstrap -> bootstrapi node_modules klasörüne dahil eder
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
          return View();
        }
    }
}