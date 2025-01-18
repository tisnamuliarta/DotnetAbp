using DotnetAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DotnetAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DotnetAbpController : AbpControllerBase
{
    protected DotnetAbpController()
    {
        LocalizationResource = typeof(DotnetAbpResource);
    }
}
