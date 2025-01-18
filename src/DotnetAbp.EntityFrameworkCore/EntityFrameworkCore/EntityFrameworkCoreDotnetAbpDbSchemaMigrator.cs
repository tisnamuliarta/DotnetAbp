using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DotnetAbp.Data;
using Volo.Abp.DependencyInjection;

namespace DotnetAbp.EntityFrameworkCore;

public class EntityFrameworkCoreDotnetAbpDbSchemaMigrator
    : IDotnetAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDotnetAbpDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DotnetAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DotnetAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
