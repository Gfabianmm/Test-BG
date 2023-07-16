using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.Entity.Seed
{
    public static class GenresSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                 new Genre { Id = 1, Description = "Acción", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 2, Description = "Aventura", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 3, Description = "Comedia", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 4, Description = "Drama", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 5, Description = "Suspenso", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 6, Description = "Terror", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 7, Description = "Ciencia ficción", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 8, Description = "Animación", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 9, Description = "Romance", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 10, Description = "Documental", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 11, Description = "Fantasía", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 12, Description = "Histórico", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 13, Description = "Misterio", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 14, Description = "Western", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 15, Description = "Musical", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 16, Description = "Deporte", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 17, Description = "Guerra", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 18, Description = "Crimen", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 19, Description = "Aventura espacial", CreatedAt = DateTime.Now, Deleted = false },
                 new Genre { Id = 20, Description = "Superhéroes", CreatedAt = DateTime.Now, Deleted = false }
            );
        }
    }

}
