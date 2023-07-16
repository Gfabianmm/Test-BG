using BackEnd.DataBase;
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
                appContext.Database.EnsureCreated();
                
            }
        }

        return host;
    }
}