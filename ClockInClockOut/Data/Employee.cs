   using System.ComponentModel.DataAnnotations;
namespace ClockInClockOut.Data
{
    public class Employee
    {
        
        [Key]
        [Range(4, 4,ErrorMessage = "Employee ID number must be 4 digits")]
        public int IdNumber { get; set; }
        public string FirstName { get; set; } =String.Empty;
        public string LastName { get; set; } = String.Empty;
        public bool IsClockedIn { get; set; } = false;

    }
}
