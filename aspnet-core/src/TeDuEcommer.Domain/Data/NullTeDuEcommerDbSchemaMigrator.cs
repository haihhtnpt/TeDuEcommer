using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TeDuEcommer.Data;

/* This is used if database provider does't define
 * ITeDuEcommerDbSchemaMigrator implementation.
 */
public class NullTeDuEcommerDbSchemaMigrator : ITeDuEcommerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
