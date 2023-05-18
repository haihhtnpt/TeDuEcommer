using TeDuEcommer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TeDuEcommer;

[DependsOn(
    typeof(TeDuEcommerEntityFrameworkCoreTestModule)
    )]
public class TeDuEcommerDomainTestModule : AbpModule
{

}
