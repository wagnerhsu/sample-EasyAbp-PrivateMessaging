using EasyAbp.PrivateMessaging.Data;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp;

namespace EasyAbp.PrivateMessaging.DbMigrator
{
    public class DbMigratorHostedService : IHostedService
    {
        private readonly IAbpApplicationWithExternalServiceProvider _application;
        private readonly IServiceProvider _serviceProvider;
        private readonly PrivateMessagingDbMigrationService _dbMigrationService;

        public DbMigratorHostedService(
            IAbpApplicationWithExternalServiceProvider application,
            IServiceProvider serviceProvider,
            PrivateMessagingDbMigrationService dbMigrationService)
        {
            _application = application;
            _serviceProvider = serviceProvider;
            _dbMigrationService = dbMigrationService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _application.Initialize(_serviceProvider);

            await _dbMigrationService.MigrateAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _application.Shutdown();

            return Task.CompletedTask;
        }
    }
}