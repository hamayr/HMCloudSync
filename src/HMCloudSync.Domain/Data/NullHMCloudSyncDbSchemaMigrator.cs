using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HMCloudSync.Data;

/* This is used if database provider does't define
 * IHMCloudSyncDbSchemaMigrator implementation.
 */
public class NullHMCloudSyncDbSchemaMigrator : IHMCloudSyncDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
