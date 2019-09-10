using Microsoft.AspNetCore.Mvc;
using mvc_core_movie_app.Data;

namespace mvc_core_movie_app.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
               return View(CategoryRepository.Categories); 
        }
    }
}