using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TeDuEcommer.Data;
using Volo.Abp.DependencyInjection;

namespace TeDuEcommer.EntityFrameworkCore;

public class EntityFrameworkCoreTeDuEcommerDbSchemaMigrator
    : ITeDuEcommerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTeDuEcommerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TeDuEcommerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TeDuEcommerDbContext>()
            .Database
            .MigrateAsync();
    }
}
