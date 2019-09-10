using Microsoft.AspNetCore.Mvc;
using mvc_core_movie_app.Data;

namespace mvc_core_movie_app.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if(RouteData.Values["action"].ToString()=="Index"){
            ViewBag.SelectedCategory=RouteData?.Values["id"];
            }
               return View(CategoryRepository.Categories); 
        }
    }
}