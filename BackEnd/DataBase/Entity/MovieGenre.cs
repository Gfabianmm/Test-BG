using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("MovieGenres")]
    public class MovieGenre
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MovieCategory")]
        public int MovieCategoryId { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }
    }
}
