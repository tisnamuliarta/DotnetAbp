using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DotnetAbp.Data;

/* This is used if database provider does't define
 * IDotnetAbpDbSchemaMigrator implementation.
 */
public class NullDotnetAbpDbSchemaMigrator : IDotnetAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
