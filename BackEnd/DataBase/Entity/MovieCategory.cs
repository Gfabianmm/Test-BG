using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("MovieCategories")]
    public class MovieCategory
    {
        
        public int MovieCategoryId { get; set; }
        public int MovieId { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }

    }
}
