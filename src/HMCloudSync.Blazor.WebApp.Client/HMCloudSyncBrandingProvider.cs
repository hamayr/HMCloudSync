using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HMCloudSync.Blazor.WebApp.Client;

[Dependency(ReplaceServices = true)]
public class HMCloudSyncBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HMCloudSync";
}
