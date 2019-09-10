using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mvc_core_movie_app.Data;
using mvc_core_movie_app.Models;

namespace mvc_core_movie_app.Controllers
{
    public class HomeController:Controller
    {
        //terminal -> npm init --yes ile package.json dosyasını otomatik projeye ekledi
        //package.jsonu eklememizin sebebi eklediğimiz tüm packageleri (örn bootstrap) kendi otomatik
        //dahil eder ve örn node_moduls klasörünü sildik. Terminale npm install dediğimizde package.jsonda
        //yazılan tüm packageleri tekrar ekler ve node_moduls klasörü geri gelir
        // npm i bootstrap -> bootstrapi node_modules klasörüne dahil eder
        public IActionResult Index(int? id)
        {
          var movies=MovieRepository.Movies;
          if(id!=null){
            movies=movies.Where(i=>i.CategoryId==id).ToList();
          }
            return View(movies);
        }

        public IActionResult Contact()
        {
          return View();
        }

        public IActionResult Details(int id)
         {
        //     MovieCategoryModel model=new MovieCategoryModel();
        //     model.Categories=CategoryRepository.Categories;
        //     model.Movie=MovieRepository.GetById(id);
          return View(MovieRepository.GetById(id));
        }
    }
}