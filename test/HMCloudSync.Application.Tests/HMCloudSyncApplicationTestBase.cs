using Volo.Abp.Modularity;

namespace HMCloudSync;

public abstract class HMCloudSyncApplicationTestBase<TStartupModule> : HMCloudSyncTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
