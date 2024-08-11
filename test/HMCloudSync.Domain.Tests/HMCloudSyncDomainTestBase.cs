using Volo.Abp.Modularity;

namespace HMCloudSync;

/* Inherit from this class for your domain layer tests. */
public abstract class HMCloudSyncDomainTestBase<TStartupModule> : HMCloudSyncTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
