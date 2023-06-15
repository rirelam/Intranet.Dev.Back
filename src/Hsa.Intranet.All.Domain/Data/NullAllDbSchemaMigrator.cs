using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Hsa.Intranet.All.Data;

/* This is used if database provider does't define
 * IAllDbSchemaMigrator implementation.
 */
public class NullAllDbSchemaMigrator : IAllDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
