using BackEnd.Domain.ActorProfile;
using BackEnd.Domain.CategoryProfile;
using BackEnd.Domain.GenreProfile;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Domain.MovieProfile
{
    public class MovieResourceSave
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public string Url { get; set; }
        public virtual List<GenreResource> MovieGenres { get; set; }
        public virtual List<CategoryResource> MovieCategories { get; set; }
        public virtual List<ActorResource> MovieActors { get; set; }
    }
}

