using Volo.Abp.Settings;

namespace DotnetAbp.Settings;

public class DotnetAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DotnetAbpSettings.MySetting1));
    }
}
