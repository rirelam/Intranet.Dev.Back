using Hsa.Intranet.All.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Hsa.Intranet.All.Permissions;

public class AllPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AllPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AllPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AllResource>(name);
    }
}
