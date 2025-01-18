﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DotnetAbp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class DotnetAbpDbContextFactory : IDesignTimeDbContextFactory<DotnetAbpDbContext>
{
    public DotnetAbpDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        DotnetAbpEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<DotnetAbpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new DotnetAbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DotnetAbp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
