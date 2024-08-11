using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace HMCloudSync.Web.Pages;

public class IndexModel : HMCloudSyncPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
