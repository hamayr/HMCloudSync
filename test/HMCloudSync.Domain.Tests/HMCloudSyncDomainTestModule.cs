using Volo.Abp.Modularity;

namespace HMCloudSync;

[DependsOn(
    typeof(HMCloudSyncDomainModule),
    typeof(HMCloudSyncTestBaseModule)
)]
public class HMCloudSyncDomainTestModule : AbpModule
{

}
