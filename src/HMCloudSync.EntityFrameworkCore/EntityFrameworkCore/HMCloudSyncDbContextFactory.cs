using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HMCloudSync.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class HMCloudSyncDbContextFactory : IDesignTimeDbContextFactory<HMCloudSyncDbContext>
{
    public HMCloudSyncDbContext CreateDbContext(string[] args)
    {
        HMCloudSyncEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<HMCloudSyncDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new HMCloudSyncDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HMCloudSync.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
