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
                  Url = "https://sm.ign.com/ign_es/movie/j/john-wick-/john-wick-4_htag.jpg"
              },
            new Movie
            {
                Id = 2,
                Name = "Mission: Impossible - Fallout",
                LongDescription = "El agente Ethan Hunt se enfrenta a su misión más peligrosa hasta ahora cuando una operación sale mal y pone en peligro a millones de personas.",
                ShortDescription = "La misión imposible más intensa y emocionante.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/724e9ee2cb3f3ac351566d0d82daa14e086b2f4ec9436d7274454198e5f2751b._RI_TTW_.jpg"
            },
            new Movie
            {
                Id = 3,
                Name = "Avengers: Infinity War",
                LongDescription = "Los Vengadores y sus aliados se unen para luchar contra el poderoso Thanos y evitar que obtenga las gemas del infinito y destruya el universo.",
                ShortDescription = "La batalla definitiva por el destino del universo.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://www.cinemascomics.com/wp-content/uploads/2018/04/poster-imax-vengadores-infinity-war.jpg"
            },
            new Movie
            {
                Id = 4,
                Name = "The Dark Knight",
                LongDescription = "Batman se enfrenta al Joker, un criminal psicótico que amenaza con sumir Gotham City en el caos y la anarquía.",
                ShortDescription = "El caballero oscuro contra el príncipe payaso del crimen.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://static.wikia.nocookie.net/batman/images/4/4b/Espanol_3584-1-.jpg/revision/latest?cb=20141102170439&path-prefix=es"
            },
            new Movie
            {
                Id = 5,
                Name = "Mad Max: Fury Road",
                LongDescription = "En un mundo postapocalíptico, Max Rockatansky y Furiosa se unen para",
                ShortDescription = "La película muestra una historia deslumbrante.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://www.dodmagazine.es/wp-content/uploads/2015/05/mad-max-fury-road.jpg"
            },
            new Movie
            {
                Id = 6,
                Name = "Die Hard",
                LongDescription = "Un policía de Nueva York se enfrenta a un grupo de terroristas en un rascacielos en Los Ángeles.",
                ShortDescription = "El héroe que salvará la Navidad.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://c8.alamy.com/compes/dtgr78/poster-de-pelicula-de-die-hard-pelicula-de-accion-estadounidense-de-1988-dirigida-por-john-mctiernan-protagonizada-por-bruce-willis-dtgr78.jpg"
            },
            new Movie
            {
                Id = 7,
                Name = "The Terminator",
                LongDescription = "Un cyborg asesino del futuro es enviado al pasado para matar a una mujer cuyo hijo se convertirá en la única esperanza de la humanidad contra las máquinas.",
                ShortDescription = "El futuro está en juego.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/23865/23865_400x600.jpg"
            },
            new Movie
            {
                Id = 8,
                Name = "Indiana Jones: Raiders of the Lost Ark",
                LongDescription = "El arqueólogo y aventurero Indiana Jones se embarca en una peligrosa misión para encontrar el Arca de la Alianza antes que los nazis.",
                ShortDescription = "La aventura comienza.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://m.media-amazon.com/images/I/81UOBSDQh0L._AC_UF894,1000_QL80_.jpg"
            },
            new Movie
            {
                Id = 9,
                Name = "Jurassic Park",
                LongDescription = "Un parque temático lleno de dinosaurios vivos se convierte en una pesadilla cuando las criaturas escapan y comienzan a causar estragos.",
                ShortDescription = "La maravilla de la prehistoria en la actualidad.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://i.pinimg.com/originals/a8/a7/70/a8a7702721817c8289afefe6a8db969f.jpg"
            },
            new Movie
            {
                Id = 10,
                Name = "The Lord of the Rings: The Fellowship of the Ring",
                LongDescription = "Un hobbit llamado Frodo se embarca en una épica aventura para destruir un anillo mágico y salvar la Tierra Media de la oscuridad.",
                ShortDescription = "El comienzo de una gran guerra.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://musicart.xboxlive.com/7/e88d5100-0000-0000-0000-000000000002/504/image.jpg?w=1920&h=1080"
            },
            new Movie
            {
                Id = 11,
                Name = "Pirates of the Caribbean: The Curse of the Black Pearl",
                LongDescription = "El Capitán Jack Sparrow se embarca en una aventura para recuperar su barco robado y salvar a una gobernadora secuestrada de una maldición pirata.",
                ShortDescription = "La vida de un pirata nunca ha sido tan divertida.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://basededatos.atrae.org/media/works/z8onk7LV9Mmw6zKz4hT6pzzvmvl.jpg"
            },
            new Movie
            {
                Id = 12,
                Name = "The Goonies",
                LongDescription = "Un grupo de amigos se embarca en una aventura en busca de un tesoro perdido para salvar sus hogares de ser demolidos.",
                ShortDescription = "La pandilla más divertida en busca de aventuras.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://r1.abcimg.es/resizer/resizer.php?imagen=https%3A%2F%2Fs3.abcstatics.com%2Fmedia%2Fpeliculas%2F000%2F004%2F490%2Flos-goonies-1.jpg&nuevoancho=683&medio=abc"
            },
            new Movie
            {
                Id = 13,
                Name = "The Mummy",
                LongDescription = "Un aventurero y una arqueóloga luchan contra una antigua maldición y enfrentan criaturas sobrenaturales mientras intentan salvar al mundo.",
                ShortDescription = "La aventura más emocionante en Egipto.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://i.etsystatic.com/22147411/r/il/ba2a32/3850948924/il_570xN.3850948924_j1eq.jpg"
            },
            new Movie
            {
                Id = 14,
                Name = "The Exorcist",
                LongDescription = "Una niña es poseída por una entidad demoníaca y un sacerdote lucha por salvar su alma.",
                ShortDescription = "El clásico del terror que te hará temblar.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://cdn.kobo.com/book-images/f9ab8287-7c5d-4650-9c92-371260037e85/1200/1200/False/leyendas-de-terror.jpg"
            },
            new Movie
            {
                Id = 15,
                Name = "The Shining",
                LongDescription = "Un escritor y su familia se mudan a un hotel aislado donde ocurren sucesos aterradores.",
                ShortDescription = "Una historia de terror psicológico que te mantendrá en vilo.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://hips.hearstapps.com/es.h-cdn.co/fotoes/images/cinefilia/mejores-posters-cine-terror-miedo/mv5bntc4odm2mtu2nf5bml5banbnxkftztgwntezntmynje-._v1_sy1000_cr0-0-647-1000_al_/137670471-1-esl-ES/MV5BNTc4ODM2MTU2NF5BMl5BanBnXkFtZTgwNTEzNTMyNjE-._V1_SY1000_CR0-0-647-1000_AL_.jpg"
            },
            new Movie
            {
                Id = 16,
                Name = "Halloween",
                LongDescription = "Un asesino enmascarado aterroriza a una pequeña ciudad en la noche de Halloween.",
                ShortDescription = "Un clásico del cine slasher que te hará saltar de miedo.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://cdn.kobo.com/book-images/f9ab8287-7c5d-4650-9c92-371260037e85/1200/1200/False/leyendas-de-terror.jpg"
            },
            new Movie
            {
                Id = 17,
                Name = "A Nightmare on Elm Street",
                LongDescription = "Un grupo de adolescentes es perseguido en sus sueños por un asesino de pesadilla.",
                ShortDescription = "No podrás dormir tranquilo después de ver esta película.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://hips.hearstapps.com/es.h-cdn.co/fotoes/images/cinefilia/mejores-posters-cine-terror-miedo/mv5bntc4odm2mtu2nf5bml5banbnxkftztgwntezntmynje-._v1_sy1000_cr0-0-647-1000_al_/137670471-1-esl-ES/MV5BNTc4ODM2MTU2NF5BMl5BanBnXkFtZTgwNTEzNTMyNjE-._V1_SY1000_CR0-0-647-1000_AL_.jpg"
            },
            new Movie
            {
                Id = 18,
                Name = "The Conjuring",
                LongDescription = "Una pareja de investigadores paranormales ayuda a una familia a enfrentarse a una presencia malévola en su casa.",
                ShortDescription = "Una historia basada en hechos reales que te dejará sin aliento.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://img2.rtve.es/imagenes/portada-tales-from-the-crypt/1625668471937.jpg"
            },
            new Movie
            {
                Id = 19,
                Name = "It",
                LongDescription = "Un grupo de niños se enfrenta a un aterrador payaso que aterroriza su ciudad.",
                ShortDescription = "El regreso del payaso más aterrador del cine.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://hips.hearstapps.com/es.h-cdn.co/fotoes/images/cinefilia/mejores-posters-cine-terror-miedo/mv5bntc4odm2mtu2nf5bml5banbnxkftztgwntezntmynje-._v1_sy1000_cr0-0-647-1000_al_/137670471-1-esl-ES/MV5BNTc4ODM2MTU2NF5BMl5BanBnXkFtZTgwNTEzNTMyNjE-._V1_SY1000_CR0-0-647-1000_AL_.jpg"
            },
            new Movie
            {
                Id = 20,
                Name = "Get Out",
                LongDescription = "Un joven negro visita la casa de la familia de su novia blanca y descubre un oscuro secreto.",
                ShortDescription = "Un thriller psicológico que te mantendrá en vilo hasta el final.",
                CreatedAt = DateTime.Now,
                Deleted = false,
                Url = "https://img2.rtve.es/imagenes/portada-tales-from-the-crypt/1625668471937.jpg"
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
                new MovieGenre { MovieId = 13, GenreId = 1, CreatedAt = DateTime.Now, Deleted = false },

                new MovieGenre { MovieId = 14, GenreId = 6, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 15, GenreId = 6, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 16, GenreId = 6, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 17, GenreId = 6, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 18, GenreId = 6, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 19, GenreId = 6, CreatedAt = DateTime.Now, Deleted = false },
                new MovieGenre { MovieId = 20, GenreId = 6, CreatedAt = DateTime.Now, Deleted = false }
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
                new MovieCategory { MovieId = 13, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },

                new MovieCategory { MovieId = 14, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 15, CategoryId = 2, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 16, CategoryId = 3, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 17, CategoryId = 3, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 18, CategoryId = 2, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 19, CategoryId = 2, CreatedAt = DateTime.Now, Deleted = false },
                new MovieCategory { MovieId = 20, CategoryId = 1, CreatedAt = DateTime.Now, Deleted = false }
            );

            modelBuilder.Entity<MovieActor>().HasData(
                new MovieActor { MovieId = 1, ActorId = 16, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 2, ActorId = 2, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 3, ActorId = 4, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 4, ActorId = 6, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 5, ActorId = 7, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 6, ActorId = 8, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 7, ActorId = 9, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 8, ActorId = 10, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 9, ActorId = 11, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 10, ActorId = 3, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 11, ActorId = 12, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 12, ActorId = 6, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 13, ActorId = 15, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 14, ActorId = 14, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 15, ActorId = 11, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 16, ActorId = 8, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 17, ActorId = 9, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 18, ActorId = 13, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 19, ActorId = 5, CreatedAt = DateTime.Now, Deleted = false },
                new MovieActor { MovieId = 20, ActorId = 6, CreatedAt = DateTime.Now, Deleted = false }
            );
        }
    }

}
