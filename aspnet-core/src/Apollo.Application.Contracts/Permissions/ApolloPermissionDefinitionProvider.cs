using Apollo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Apollo.Permissions;

public class ApolloPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ApolloPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ApolloPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ApolloResource>(name);
    }
}
