using Volo.Abp.Modularity;

namespace Sales;

[DependsOn(
    typeof(SalesDomainModule),
    typeof(SalesTestBaseModule)
)]
public class SalesDomainTestModule : AbpModule
{

}
