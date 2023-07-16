using BackEnd.DataBase.Entity;
using BackEnd.DataBase.Entity.Seed;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BackEnd.DataBase
{
    public class DBTestBGContext : DbContext
    {
        public DBTestBGContext(DbContextOptions<DBTestBGContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>().HasKey(e => new { e.MovieId, e.ActorId });
            modelBuilder.Entity<MovieCategory>().HasKey(e => new { e.MovieId, e.CategoryId });
            modelBuilder.Entity<MovieGenre>().HasKey(e => new { e.MovieId, e.GenreId });
            

            ActorsSeed.Seed(modelBuilder);
            CategoriesSeed.Seed(modelBuilder);
            GenresSeed.Seed(modelBuilder);
            MoviesSeed.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
