using Volo.Abp.Settings;

namespace Hsa.Intranet.All.Settings;

public class AllSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AllSettings.MySetting1));
    }
}
