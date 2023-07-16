using BackEnd.DataBase.Entity;
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
            modelBuilder.Entity<MovieCategory>().HasKey(e => new { e.MovieId, e.MovieCategoryId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<MovieActor> MovieActor { get; set; }
        public DbSet<MovieCategory> MovieCategory { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
