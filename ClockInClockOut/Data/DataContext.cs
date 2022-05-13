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
                new Record { ItemNumber = 1, IdNumber = 1995, EmployeeName ="Hensley Wint", ClockInTime= DateTime.MinValue, ClockOutTime= DateTime.MinValue, TotalHoursWorked =0.0},
                new Record { ItemNumber = 2, IdNumber = 2020, EmployeeName = "Jason Choi", ClockInTime = DateTime.MinValue, ClockOutTime = DateTime.MinValue, TotalHoursWorked = 0.0 },
                new Record { ItemNumber = 3, IdNumber = 1234, EmployeeName ="Max Samuel" , ClockInTime = DateTime.MinValue, ClockOutTime = DateTime.MinValue, TotalHoursWorked = 0.0 }

                );


        }


        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Record> Records => Set<Record>();
    }
}
