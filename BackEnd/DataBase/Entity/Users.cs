using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Names { get; set; }
        public string Password { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }
    }
}
