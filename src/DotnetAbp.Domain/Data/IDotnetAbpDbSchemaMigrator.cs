using System.Threading.Tasks;

namespace DotnetAbp.Data;

public interface IDotnetAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
