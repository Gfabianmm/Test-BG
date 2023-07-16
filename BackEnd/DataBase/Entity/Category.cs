using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }

    }
}
