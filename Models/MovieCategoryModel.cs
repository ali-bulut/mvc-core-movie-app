using System.Collections.Generic;
namespace mvc_core_movie_app.Models
{
    public class MovieCategoryModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Movie Movie { get; set; }
    }
}