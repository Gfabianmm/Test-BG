using BackEnd.DataBase;
using BackEnd.DataBase.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackEnd;
public static class MigrationManager
{
    public static IHost MigrateDatabase<TContext>(this IHost host) where TContext : DbContext
    {
        using (var scope = host.Services.CreateScope())
        {
            using (var appContext = scope.ServiceProvider.GetRequiredService<TContext>())
            {
                //if (appContext.Database.CanConnect())
                //{

                appContext.Database.Migrate();
                //if (appContext.Set<User>().Any())
                //{

                //}


                //}
                //else
                //{
                //    appContext.Database.EnsureCreated();
                //}


            }
        }

        return host;
    }
}