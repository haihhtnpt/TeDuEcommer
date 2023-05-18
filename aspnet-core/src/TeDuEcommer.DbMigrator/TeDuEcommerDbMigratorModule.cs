using TeDuEcommer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TeDuEcommer.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TeDuEcommerEntityFrameworkCoreModule),
    typeof(TeDuEcommerApplicationContractsModule)
    )]
public class TeDuEcommerDbMigratorModule : AbpModule
{

}
