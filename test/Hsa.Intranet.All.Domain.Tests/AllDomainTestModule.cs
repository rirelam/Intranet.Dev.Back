using Hsa.Intranet.All.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Hsa.Intranet.All;

[DependsOn(
    typeof(AllEntityFrameworkCoreTestModule)
    )]
public class AllDomainTestModule : AbpModule
{

}
