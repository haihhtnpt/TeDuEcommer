using Volo.Abp.Settings;

namespace TeDuEcommer.Settings;

public class TeDuEcommerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TeDuEcommerSettings.MySetting1));
    }
}
