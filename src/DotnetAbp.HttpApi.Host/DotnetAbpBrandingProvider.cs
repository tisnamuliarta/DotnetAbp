using Microsoft.Extensions.Localization;
using DotnetAbp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DotnetAbp;

[Dependency(ReplaceServices = true)]
public class DotnetAbpBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<DotnetAbpResource> _localizer;

    public DotnetAbpBrandingProvider(IStringLocalizer<DotnetAbpResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
