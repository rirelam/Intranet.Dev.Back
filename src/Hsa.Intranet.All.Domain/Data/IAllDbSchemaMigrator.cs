using System.Threading.Tasks;

namespace Hsa.Intranet.All.Data;

public interface IAllDbSchemaMigrator
{
    Task MigrateAsync();
}
