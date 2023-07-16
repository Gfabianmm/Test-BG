using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public int MovieCategoryId { get; set; }
        public int MovieGenreId { get; set; }
        public int MovieActorId { get; set; }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }

        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("MovieGenreId")]
        public virtual List<MovieGenre> MovieGenre { get; set; }

        [ForeignKey("MovieCategoryId")]
        public virtual List<MovieCategory> MovieCategory { get; set; }

        [ForeignKey("MovieActorId")]
        public virtual List<MovieActor> MovieActor { get; set; }
    }
}

