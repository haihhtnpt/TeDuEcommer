using System.Threading.Tasks;

namespace TeDuEcommer.Data;

public interface ITeDuEcommerDbSchemaMigrator
{
    Task MigrateAsync();
}
