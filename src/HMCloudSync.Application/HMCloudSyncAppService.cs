using System;
using System.Collections.Generic;
using System.Text;
using HMCloudSync.Localization;
using Volo.Abp.Application.Services;

namespace HMCloudSync;

/* Inherit your application services from this class.
 */
public abstract class HMCloudSyncAppService : ApplicationService
{
    protected HMCloudSyncAppService()
    {
        LocalizationResource = typeof(HMCloudSyncResource);
    }
}
