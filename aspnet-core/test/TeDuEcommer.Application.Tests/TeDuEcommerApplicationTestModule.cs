using Volo.Abp.Modularity;

namespace TeDuEcommer;

[DependsOn(
    typeof(TeDuEcommerApplicationModule),
    typeof(TeDuEcommerDomainTestModule)
    )]
public class TeDuEcommerApplicationTestModule : AbpModule
{

}
