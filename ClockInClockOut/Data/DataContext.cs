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

            modelBuilder.Entity<Record>().HasData(
                new Record { IdNumber = 1995, ClockInTime= DateTime.Now, ClockOutTime= DateTime.Now,TotalHoursWorked =0.0},
                new Record { IdNumber = 2020, ClockInTime = DateTime.Now, ClockOutTime = DateTime.Now, TotalHoursWorked = 0.0 },
                new Record { IdNumber = 1234, ClockInTime = DateTime.Now, ClockOutTime = DateTime.Now, TotalHoursWorked = 0.0 }

                );


        }


        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Record> Records => Set<Record>();
    }
}
