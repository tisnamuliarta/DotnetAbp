using Volo.Abp.Modularity;

namespace DotnetAbp;

/* Inherit from this class for your domain layer tests. */
public abstract class DotnetAbpDomainTestBase<TStartupModule> : DotnetAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
