using Volo.Abp.Modularity;

namespace DotnetAbp;

[DependsOn(
    typeof(DotnetAbpDomainModule),
    typeof(DotnetAbpTestBaseModule)
)]
public class DotnetAbpDomainTestModule : AbpModule
{

}
