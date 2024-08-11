using HMCloudSync.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HMCloudSync.Permissions;

public class HMCloudSyncPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HMCloudSyncPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HMCloudSyncPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HMCloudSyncResource>(name);
    }
}
