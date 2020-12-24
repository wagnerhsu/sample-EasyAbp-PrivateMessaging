using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAbp.PrivateMessaging.EFCore.DbMigrations.EFCore
{
    public class PrivateMessagingMigrationsDbContextFactory : IDesignTimeDbContextFactory<PrivateMessagingMigrationsDbContext>
    {
        public PrivateMessagingMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PrivateMessagingMigrationsDbContext>()
                .UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=PrivateMessaging;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new PrivateMessagingMigrationsDbContext(builder.Options);
        }

        private static IConfiguration BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
