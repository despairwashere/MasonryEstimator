using MasonryEstimator.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace MasonryEstimator.Data
{
    public class MasonryContext : DbContext
    {
        public DbSet<Project> Projects => Set<Project>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString =
                    "server=localhost;port=3307;database=masonryestimator;user=masonryuser;password=StrongPassword123!;";

                optionsBuilder.UseMySQL(connectionString);
            }
        }
    }
}
