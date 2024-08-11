using Volo.Abp.Modularity;

namespace HMCloudSync;

[DependsOn(
    typeof(HMCloudSyncApplicationModule),
    typeof(HMCloudSyncDomainTestModule)
)]
public class HMCloudSyncApplicationTestModule : AbpModule
{

}
