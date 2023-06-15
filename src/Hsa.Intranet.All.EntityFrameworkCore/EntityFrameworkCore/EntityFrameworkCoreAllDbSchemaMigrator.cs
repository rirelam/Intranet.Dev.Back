using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Hsa.Intranet.All.Data;
using Volo.Abp.DependencyInjection;

namespace Hsa.Intranet.All.EntityFrameworkCore;

public class EntityFrameworkCoreAllDbSchemaMigrator
    : IAllDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAllDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AllDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AllDbContext>()
            .Database
            .MigrateAsync();
    }
}
