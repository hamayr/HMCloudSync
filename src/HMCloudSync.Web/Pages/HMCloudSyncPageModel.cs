using HMCloudSync.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HMCloudSync.Web.Pages;

public abstract class HMCloudSyncPageModel : AbpPageModel
{
    protected HMCloudSyncPageModel()
    {
        LocalizationResourceType = typeof(HMCloudSyncResource);
    }
}
