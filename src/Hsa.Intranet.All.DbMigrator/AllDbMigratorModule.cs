using Hsa.Intranet.All.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Hsa.Intranet.All.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AllEntityFrameworkCoreModule),
    typeof(AllApplicationContractsModule)
    )]
public class AllDbMigratorModule : AbpModule
{

}
