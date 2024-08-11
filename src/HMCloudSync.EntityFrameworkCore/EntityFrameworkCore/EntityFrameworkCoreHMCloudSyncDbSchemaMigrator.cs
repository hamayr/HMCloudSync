using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HMCloudSync.Data;
using Volo.Abp.DependencyInjection;

namespace HMCloudSync.EntityFrameworkCore;

public class EntityFrameworkCoreHMCloudSyncDbSchemaMigrator
    : IHMCloudSyncDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHMCloudSyncDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the HMCloudSyncDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HMCloudSyncDbContext>()
            .Database
            .MigrateAsync();
    }
}
