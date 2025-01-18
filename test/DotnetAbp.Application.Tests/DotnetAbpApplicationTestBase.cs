using Volo.Abp.Modularity;

namespace DotnetAbp;

public abstract class DotnetAbpApplicationTestBase<TStartupModule> : DotnetAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
