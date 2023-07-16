using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.Entity.Seed
{
    public static class CategoriesSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Description = "+18", CreatedAt = DateTime.Now, Deleted = false },
                new Category { Id = 2, Description = "+21", CreatedAt = DateTime.Now, Deleted = false },
                new Category { Id = 3, Description = "+12", CreatedAt = DateTime.Now, Deleted = false },
                new Category { Id = 4, Description = "+9", CreatedAt = DateTime.Now, Deleted = false },
                new Category { Id = 5, Description = "Todo público", CreatedAt = DateTime.Now, Deleted = false }
            );
        }
    }

}
