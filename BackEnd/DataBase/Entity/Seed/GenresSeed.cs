using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.Entity.Seed
{
    public static class GenresSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                 new Genre { Id = 1, Description = "Acción", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 2, Description = "Aventura", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 3, Description = "Comedia", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 4, Description = "Drama", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 5, Description = "Suspenso", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 6, Description = "Terror", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 7, Description = "Ciencia ficción", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 8, Description = "Animación", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 9, Description = "Romance", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 10, Description = "Documental", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 11, Description = "Fantasía", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 12, Description = "Histórico", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 13, Description = "Misterio", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 14, Description = "Western", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 15, Description = "Musical", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 16, Description = "Deporte", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 17, Description = "Guerra", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 18, Description = "Crimen", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 19, Description = "Aventura espacial", CreateAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 20, Description = "Superhéroes", CreateAt = DateTime.Now, Deleted = false }
            );
        }
    }

}
