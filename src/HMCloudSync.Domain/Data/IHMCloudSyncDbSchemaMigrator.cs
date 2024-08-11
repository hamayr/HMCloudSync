using System.Threading.Tasks;

namespace HMCloudSync.Data;

public interface IHMCloudSyncDbSchemaMigrator
{
    Task MigrateAsync();
}
