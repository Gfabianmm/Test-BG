using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        
        [DefaultValue("")]
        public string Url { get; set; }

        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }

        public virtual List<MovieGenre> MovieGenres { get; set; }

        public virtual List<MovieCategory> MovieCategories { get; set; }


        public virtual List<MovieActor> MovieActors { get; set; }
    }
}

