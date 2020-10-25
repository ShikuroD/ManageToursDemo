using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure
{
    public class ManageToursContextFactory : IDesignTimeDbContextFactory<ManageToursContext>
    {
        public ManageToursContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ManageToursContext>();
            optionsBuilder.UseSqlite($"Data Source=tours.db");

            return new ManageToursContext(optionsBuilder.Options);
        }
    }
}