using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.Entity.Seed
{
    public static class CategoriesSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Description = "+18", CreateAt = DateTime.Now, Deleted = false },
                new Category { Id = 2, Description = "+21", CreateAt = DateTime.Now, Deleted = false },
                new Category { Id = 3, Description = "+12", CreateAt = DateTime.Now, Deleted = false },
                new Category { Id = 4, Description = "+9", CreateAt = DateTime.Now, Deleted = false },
                new Category { Id = 5, Description = "Todo público", CreateAt = DateTime.Now, Deleted = false }
            );
        }
    }

}
