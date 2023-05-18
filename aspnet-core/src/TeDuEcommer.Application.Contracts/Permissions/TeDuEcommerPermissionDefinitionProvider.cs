using TeDuEcommer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TeDuEcommer.Permissions;

public class TeDuEcommerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TeDuEcommerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TeDuEcommerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TeDuEcommerResource>(name);
    }
}
