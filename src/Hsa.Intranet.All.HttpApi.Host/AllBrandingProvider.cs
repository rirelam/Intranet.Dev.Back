using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Hsa.Intranet.All;

[Dependency(ReplaceServices = true)]
public class AllBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "All";
}
