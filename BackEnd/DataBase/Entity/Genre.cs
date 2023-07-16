using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace BackEnd.DataBase.Entity
{
    [Table("Genres")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }
        

    }
}
