using Volo.Abp.Settings;

namespace Apollo.Settings;

public class ApolloSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ApolloSettings.MySetting1));
    }
}
