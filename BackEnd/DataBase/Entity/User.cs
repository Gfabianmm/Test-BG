using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Names { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool Deleted { get; set; }
    }
}
