using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.Entity.Seed
{
    public static class ActorsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Brad Pitt", Description = "Actor famoso de Hollywood", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 2, Name = "Leonardo DiCaprio", Description = "Actor destacado en múltiples películas", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 3, Name = "Meryl Streep", Description = "Actriz talentosa y versátil", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 4, Name = "Tom Hanks", Description = "Actor icónico de la industria cinematográfica", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 5, Name = "Scarlett Johansson", Description = "Actriz conocida por su papel en películas de superhéroes", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 6, Name = "Robert Downey Jr.", Description = "Actor reconocido por interpretar a Iron Man", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 7, Name = "Jennifer Lawrence", Description = "Actriz ganadora de premios y reconocida por Los juegos del hambre", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 8, Name = "Denzel Washington", Description = "Actor destacado en películas dramáticas", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 9, Name = "Emma Stone", Description = "Actriz talentosa y versátil", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 10, Name = "Johnny Depp", Description = "Actor conocido por su interpretación de personajes excéntricos", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 11, Name = "Anne Hathaway", Description = "Actriz versátil y ganadora del premio de la Academia", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 12, Name = "Chris Hemsworth", Description = "Actor australiano conocido por interpretar a Thor", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 13, Name = "Natalie Portman", Description = "Actriz versátil y ganadora del premio de la Academia", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 14, Name = "Bradley Cooper", Description = "Actor conocido por películas como El lado bueno de las cosas", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 15, Name = "Angelina Jolie", Description = "Actriz y activista conocida por su papel en Tomb Raider", CreateAt = DateTime.Now, Deleted = false },
                new Actor { Id = 16, Name = "Keanu Reeves", Description = "Actordestacado en películas de acción", CreateAt = DateTime.Now, Deleted = false }
            );


        }
    }

}
