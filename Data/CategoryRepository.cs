using System.Collections.Generic;
using System.Linq;
using mvc_core_movie_app.Models;

namespace mvc_core_movie_app.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories=null;
        static CategoryRepository()
        {
            _categories=new List<Category>(){
                new Category() {Id=1,Name="Comedy"},
                new Category() {Id=2,Name="Drama"},
                new Category() {Id=3,Name="Crime"},
                new Category() {Id=4,Name="Military"},
                new Category() {Id=5,Name="Horror"},
               
            };
        }
        public static List<Category> Categories{
            get{
                return _categories;
            }
        }

        public static void AddCategory(Category entity){
            _categories.Add(entity);
        }

        public static Category GetById(int id){
            return _categories.FirstOrDefault(i=>i.Id==id);
        }
    }
}