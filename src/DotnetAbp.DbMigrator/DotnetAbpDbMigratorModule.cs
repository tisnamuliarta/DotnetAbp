using DotnetAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DotnetAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DotnetAbpEntityFrameworkCoreModule),
    typeof(DotnetAbpApplicationContractsModule)
)]
public class DotnetAbpDbMigratorModule : AbpModule
{
}
