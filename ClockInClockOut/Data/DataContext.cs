using Microsoft.EntityFrameworkCore;

namespace ClockInClockOut.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { IdNumber = 1995, FirstName ="Hensley", LastName ="Wint", IsClockedIN = false },
                new Employee { IdNumber = 2020, FirstName = "Jason", LastName = "Choi", IsClockedIN = false },
                new Employee { IdNumber = 1234, FirstName = "Max", LastName = "Samuel", IsClockedIN = false }

                );
            
        }


        public DbSet<Employee> Employees => Set<Employee>();
    }
}
