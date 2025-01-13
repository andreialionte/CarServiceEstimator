using CarServiceEstimator.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CarServiceEstimator
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CarServiceDB;User ID=sa;Password=NewPassword123!;TrustServerCertificate=true;");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
