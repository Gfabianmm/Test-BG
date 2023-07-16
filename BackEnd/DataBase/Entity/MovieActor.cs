using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("MovieActors")]
    public class MovieActor
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }

    }
}
