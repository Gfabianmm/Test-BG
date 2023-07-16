using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("MovieGenres")]
    public class MovieGenre
    {
        
        public int GenreId { get; set; }
        public int MovieId { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }
        
        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }
    }
}
