using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using BokmalensWebbshop.Models;

namespace BokmalensWebbshop.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=bokmalens;Username=postgres;Password=Bokmalens2025!");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
