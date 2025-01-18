using Volo.Abp.Modularity;

namespace Sales;

[DependsOn(
    typeof(SalesApplicationModule),
    typeof(SalesDomainTestModule)
    )]
public class SalesApplicationTestModule : AbpModule
{

}
