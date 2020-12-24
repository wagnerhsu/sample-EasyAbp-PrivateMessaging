using EasyAbp.PrivateMessaging.EFCore.DbMigrations.EFCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace EasyAbp.PrivateMessaging.DbMigrator
{

    [DependsOn(
        typeof(PrivateMessagingDomainModule),
        typeof(PrivateMessagingEFCoreMigrationsModule),
        typeof(AbpAutofacModule)
    )]
    public class DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            var hostEnvironment = context.Services.GetSingletonInstance<IHostEnvironment>();

            context.Services.AddHostedService<DbMigratorHostedService>();
        }
    }
}
