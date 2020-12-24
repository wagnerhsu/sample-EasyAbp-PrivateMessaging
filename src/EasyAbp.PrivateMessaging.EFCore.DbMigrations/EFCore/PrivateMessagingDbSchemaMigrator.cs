using EasyAbp.PrivateMessaging.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.PrivateMessaging.EFCore.DbMigrations.EFCore
{
    [Dependency(ReplaceServices = true)]

    public class PrivateMessagingDbSchemaMigrator : IPrivateMessagingDbSchemaMigrator, ITransientDependency
    {
        private readonly PrivateMessagingMigrationsDbContext dbContext;

        public PrivateMessagingDbSchemaMigrator(PrivateMessagingMigrationsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task MigrateAsync()
        {
            await dbContext.Database.MigrateAsync();
        }
    }
}
