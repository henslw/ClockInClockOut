namespace ClockInClockOut.Data
{
    public interface IEmployeeServices
    {
        List<Employee> Employees { get; set; }
        Task LoadEmployees();
        Task <Employee> GetEmployee(int IdNumber);
        Task CreateEmployee(Employee employee);
        // for CRUD operation
        Task UpdateEmployee(Employee employee, int IdNumber);
        
        // for clock in/out update employee
        Task UpdateEmployee2(Employee employee, int IdNumber);

        Task DeleteEmployee(int IdNumber);
    }
}
