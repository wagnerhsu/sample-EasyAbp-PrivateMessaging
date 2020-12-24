using EasyAbp.PrivateMessaging.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace EasyAbp.PrivateMessaging.EFCore.DbMigrations.EFCore
{
    [DependsOn(
        typeof(PrivateMessagingEntityFrameworkCoreModule)
        )]
    public class PrivateMessagingEFCoreMigrationsModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PrivateMessagingMigrationsDbContext>();
        }
    }
}
