using Volo.Abp.Modularity;

namespace Hsa.Intranet.All;

[DependsOn(
    typeof(AllApplicationModule),
    typeof(AllDomainTestModule)
    )]
public class AllApplicationTestModule : AbpModule
{

}
