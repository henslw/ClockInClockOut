namespace ClockInClockOut.Data
{
    public interface IEmployeeServices
    {
        List<Employee> Employees { get; set; }
        Task LoadEmployees();
        Task <Employee> GetEmployee(int IdNumber);
        Task CreateEmployee(Employee employee);
        Task UpdateEmployee(Employee employee, int IdNumber);
        Task DeleteEmployee(int IdNumber);
    }
}
