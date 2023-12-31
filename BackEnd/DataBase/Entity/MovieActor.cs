﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Entity
{
    [Table("MovieActors")]
    public class MovieActor
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }

    }
}
