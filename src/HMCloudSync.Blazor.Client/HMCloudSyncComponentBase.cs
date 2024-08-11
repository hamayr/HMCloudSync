using HMCloudSync.Localization;
using Volo.Abp.AspNetCore.Components;

namespace HMCloudSync.Blazor.Client;

public abstract class HMCloudSyncComponentBase : AbpComponentBase
{
    protected HMCloudSyncComponentBase()
    {
        LocalizationResource = typeof(HMCloudSyncResource);
    }
}
