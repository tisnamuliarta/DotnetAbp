using DotnetAbp.Localization;
using Volo.Abp.Application.Services;

namespace DotnetAbp;

/* Inherit your application services from this class.
 */
public abstract class DotnetAbpAppService : ApplicationService
{
    protected DotnetAbpAppService()
    {
        LocalizationResource = typeof(DotnetAbpResource);
    }
}
