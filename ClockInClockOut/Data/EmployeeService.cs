using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
namespace ClockInClockOut.Data
{
    public class EmployeeService : IEmployeeServices
    {

        private readonly DataContext _context;
        private readonly NavigationManager _navigationManager;

        public EmployeeService(DataContext context, NavigationManager navigationManager)
        {

            _context = context;
            _navigationManager = navigationManager;
            _context.Database.EnsureCreated();
        }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public async Task CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("AdminEmployee");
        }

        public async Task DeleteEmployee(int Id)
        {
            var employee = await _context.Employees.FindAsync(Id);
            if (employee == null)
                throw new Exception("Employee not found.");
            
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("AdminEmployee");
        }

        public async Task<Employee> GetEmployee(int Id)
        {
            var employee = await _context.Employees.FindAsync(Id);
            if (employee == null)
            {
                throw new Exception("Employee not found.");
            }
            return employee;
        }

        public async Task LoadEmployees()
        {
            Employees = await _context.Employees.ToListAsync();
        }

        public async Task UpdateEmployee(Employee employee, int Id)
        {
            var dbEmployee = await _context.Employees.FindAsync(Id);
            if(dbEmployee == null)
                throw new Exception("Employee not found.");
            dbEmployee.IdNumber = employee.IdNumber;
            dbEmployee.FirstName= employee.FirstName;
            dbEmployee.LastName= employee.LastName;
            dbEmployee.IsClockedIN = employee.IsClockedIN;

            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("AdminEmployee");
        }

        public async Task UpdateEmployee2(Employee employee, int Id)
        {
            var dbEmployee = await _context.Employees.FindAsync(Id);
            if (dbEmployee == null)
                throw new Exception("Employee not found.");
            dbEmployee.IdNumber = employee.IdNumber;
            dbEmployee.FirstName = employee.FirstName;
            dbEmployee.LastName = employee.LastName;
            dbEmployee.IsClockedIN = employee.IsClockedIN;

            await _context.SaveChangesAsync();
        }
    }
}
