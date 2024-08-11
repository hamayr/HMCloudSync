using HMCloudSync.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HMCloudSync.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HMCloudSyncController : AbpControllerBase
{
    protected HMCloudSyncController()
    {
        LocalizationResource = typeof(HMCloudSyncResource);
    }
}
