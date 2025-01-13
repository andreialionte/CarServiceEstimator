using CarServiceEstimator.Helpers;
using Microsoft.EntityFrameworkCore;

namespace CarServiceEstimator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CarServiceDB;User ID=sa;Password=NewPassword123!;TrustServerCertificate=true;");

            //using (var dbContext = new DataContext(optionsBuilder.Options))
            //{
            //    // database checker exist
            //    dbContext.Database.EnsureCreated();
            //}

            var dbContext = new DataContext(optionsBuilder.Options);

            // Run the application with the StartForm
            Application.Run(new StartForm(dbContext));
        }
    }
}
