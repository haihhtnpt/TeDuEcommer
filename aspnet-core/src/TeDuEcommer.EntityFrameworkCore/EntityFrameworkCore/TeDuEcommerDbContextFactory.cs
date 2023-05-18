using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TeDuEcommer.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TeDuEcommerDbContextFactory : IDesignTimeDbContextFactory<TeDuEcommerDbContext>
{
    public TeDuEcommerDbContext CreateDbContext(string[] args)
    {
        TeDuEcommerEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TeDuEcommerDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TeDuEcommerDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TeDuEcommer.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
