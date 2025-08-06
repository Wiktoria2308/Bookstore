using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using BokmalensWebbshop.Models;
using System;


namespace BokmalensWebbshop.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Missing DB_CONNECTION environment variable.");
        }

        optionsBuilder.UseNpgsql(connectionString);
        return new AppDbContext(optionsBuilder.Options);
        }
    }
}
