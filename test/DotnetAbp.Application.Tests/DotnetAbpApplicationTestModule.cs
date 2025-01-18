using Volo.Abp.Modularity;

namespace DotnetAbp;

[DependsOn(
    typeof(DotnetAbpApplicationModule),
    typeof(DotnetAbpDomainTestModule)
)]
public class DotnetAbpApplicationTestModule : AbpModule
{

}
