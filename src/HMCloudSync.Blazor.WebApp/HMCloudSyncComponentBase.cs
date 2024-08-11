using HMCloudSync.Localization;
using Volo.Abp.AspNetCore.Components;

namespace HMCloudSync.Blazor.WebApp;

public abstract class HMCloudSyncComponentBase : AbpComponentBase
{
    protected HMCloudSyncComponentBase()
    {
        LocalizationResource = typeof(HMCloudSyncResource);
    }
}
