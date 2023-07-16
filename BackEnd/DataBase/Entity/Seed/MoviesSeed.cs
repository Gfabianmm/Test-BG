using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.Entity.Seed
{
    public static class MoviesSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
              new Movie
              {
                  Id = 1,
                  Name = "John Wick",
                  LongDescription = "Un exasesino busca venganza después de que le roban lo más preciado que le quedaba: su perro.",
                  ShortDescription = "Un hombre en busca de justicia en un mundo de asesinos.",
                  CreatedAt = DateTime.Now,
                  Deleted = false,
                  Url = "https://example.com/john-wick.jpg"
              },
            new Movie
            {
                Id = 2,
                Name = "Mission: Impossible - Fallout",
                LongDescription = "El agente Ethan Hunt se enfrenta a su misión más peligrosa hasta ahora cuando una operación sale mal y pone en peligro a millones de personas.",
                ShortDescription = "La misión imposible más intensa y emocionante.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/mission-impossible-fallout.jpg"
            },
            new Movie
            {
                Id = 3,
                Name = "Avengers: Infinity War",
                LongDescription = "Los Vengadores y sus aliados se unen para luchar contra el poderoso Thanos y evitar que obtenga las gemas del infinito y destruya el universo.",
                ShortDescription = "La batalla definitiva por el destino del universo.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/avengers-infinity-war.jpg"
            },
            new Movie
            {
                Id = 4,
                Name = "The Dark Knight",
                LongDescription = "Batman se enfrenta al Joker, un criminal psicótico que amenaza con sumir Gotham City en el caos y la anarquía.",
                ShortDescription = "El caballero oscuro contra el príncipe payaso del crimen.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/the-dark-knight.jpg"
            },
            new Movie
            {
                Id = 5,
                Name = "Mad Max: Fury Road",
                LongDescription = "En un mundo postapocalíptico, Max Rockatansky y Furiosa se unen para",
                ShortDescription = "La película muestra una historia deslumbrante.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/mad-max-fury-road.jpg"
            },
            new Movie
            {
                Id = 6,
                Name = "Die Hard",
                LongDescription = "Un policía de Nueva York se enfrenta a un grupo de terroristas en un rascacielos en Los Ángeles.",
                ShortDescription = "El héroe que salvará la Navidad.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/die-hard.jpg"
            },
            new Movie
            {
                Id = 7,
                Name = "The Terminator",
                LongDescription = "Un cyborg asesino del futuro es enviado al pasado para matar a una mujer cuyo hijo se convertirá en la única esperanza de la humanidad contra las máquinas.",
                ShortDescription = "El futuro está en juego.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/the-terminator.jpg"
            },
            new Movie
            {
                Id = 8,
                Name = "Indiana Jones: Raiders of the Lost Ark",
                LongDescription = "El arqueólogo y aventurero Indiana Jones se embarca en una peligrosa misión para encontrar el Arca de la Alianza antes que los nazis.",
                ShortDescription = "La aventura comienza.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/indiana-jones-raiders-of-the-lost-ark.jpg"
            },
            new Movie
            {
                Id = 9,
                Name = "Jurassic Park",
                LongDescription = "Un parque temático lleno de dinosaurios vivos se convierte en una pesadilla cuando las criaturas escapan y comienzan a causar estragos.",
                ShortDescription = "La maravilla de la prehistoria en la actualidad.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/jurassic-park.jpg"
            },
            new Movie
            {
                Id = 10,
                Name = "The Lord of the Rings: The Fellowship of the Ring",
                LongDescription = "Un hobbit llamado Frodo se embarca en una épica aventura para destruir un anillo mágico y salvar la Tierra Media de la oscuridad.",
                ShortDescription = "El comienzo de una gran guerra.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/the-lord-of-the-rings-the-fellowship-of-the-ring.jpg"
            },
            new Movie
            {
                Id = 11,
                Name = "Pirates of the Caribbean: The Curse of the Black Pearl",
                LongDescription = "El Capitán Jack Sparrow se embarca en una aventura para recuperar su barco robado y salvar a una gobernadora secuestrada de una maldición pirata.",
                ShortDescription = "La vida de un pirata nunca ha sido tan divertida.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/pirates-of-the-caribbean-the-curse-of-the-black-pearl.jpg"
            },
            new Movie
            {
                Id = 12,
                Name = "The Goonies",
                LongDescription = "Un grupo de amigos se embarca en una aventura en busca de un tesoro perdido para salvar sus hogares de ser demolidos.",
                ShortDescription = "La pandilla más divertida en busca de aventuras.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/the-goonies.jpg"
            },
            new Movie
            {
                Id = 13,
                Name = "The Mummy",
                LongDescription = "Un aventurero y una arqueóloga luchan contra una antigua maldición y enfrentan criaturas sobrenaturales mientras intentan salvar al mundo.",
                ShortDescription = "La aventura más emocionante en Egipto.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/the-mummy.jpg"
            },
            new Movie
            {
                Id = 14,
                Name = "The Exorcist",
                LongDescription = "Una niña es poseída por una entidad demoníaca y un sacerdote lucha por salvar su alma.",
                ShortDescription = "El clásico del terror que te hará temblar.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/the-exorcist.jpg"
            },
            new Movie
            {
                Id = 15,
                Name = "The Shining",
                LongDescription = "Un escritor y su familia se mudan a un hotel aislado donde ocurren sucesos aterradores.",
                ShortDescription = "Una historia de terror psicológico que te mantendrá en vilo.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/the-shining.jpg"
            },
            new Movie
            {
                Id = 16,
                Name = "Halloween",
                LongDescription = "Un asesino enmascarado aterroriza a una pequeña ciudad en la noche de Halloween.",
                ShortDescription = "Un clásico del cine slasher que te hará saltar de miedo.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/halloween.jpg"
            },
            new Movie
            {
                Id = 17,
                Name = "A Nightmare on Elm Street",
                LongDescription = "Un grupo de adolescentes es perseguido en sus sueños por un asesino de pesadilla.",
                ShortDescription = "No podrás dormir tranquilo después de ver esta película.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/nightmare-on-elm-street.jpg"
            },
            new Movie
            {
                Id = 18,
                Name = "The Conjuring",
                LongDescription = "Una pareja de investigadores paranormales ayuda a una familia a enfrentarse a una presencia malévola en su casa.",
                ShortDescription = "Una historia basada en hechos reales que te dejará sin aliento.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/the-conjuring.jpg"
            },
            new Movie
            {
                Id = 19,
                Name = "It",
                LongDescription = "Un grupo de niños se enfrenta a un aterrador payaso que aterroriza su ciudad.",
                ShortDescription = "El regreso del payaso más aterrador del cine.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/it.jpg"
            },
            new Movie
            {
                Id = 20,
                Name = "Get Out",
                LongDescription = "Un joven negro visita la casa de la familia de su novia blanca y descubre un oscuro secreto.",
                ShortDescription = "Un thriller psicológico que te mantendrá en vilo hasta el final.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://example.com/get-out.jpg"
            }
          );

            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre { MovieId = 1, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 2, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 3, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 4, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 5, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 6, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 7, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 8, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 9, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 10, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 11, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 12, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 13, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false }
            );

            modelBuilder.Entity<MovieCategory>().HasData(
                new MovieCategory { MovieId = 1, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 2, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 3, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 4, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 5, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 6, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 7, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 8, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 9, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 10, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 11, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 12, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 13, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false }
            );

            modelBuilder.Entity<MovieActor>().HasData(
                new MovieActor { MovieId = 1, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 2, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 3, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 4, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 5, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 6, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 7, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 8, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 9, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 10, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 11, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 12, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 13, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false }
            );
        }
    }

}
