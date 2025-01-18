using Sales.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sales;

public abstract class SalesController : AbpControllerBase
{
    protected SalesController()
    {
        LocalizationResource = typeof(SalesResource);
    }
}
