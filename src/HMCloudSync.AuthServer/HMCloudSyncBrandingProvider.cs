using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace HMCloudSync;

[Dependency(ReplaceServices = true)]
public class HMCloudSyncBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HMCloudSync";
}
