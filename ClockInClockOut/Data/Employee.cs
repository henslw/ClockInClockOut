   using System.ComponentModel.DataAnnotations;

namespace ClockInClockOut.Data
{
    public class Employee
    {
        
        [Key]
        public int IdNumber { get; set; }
        public string FirstName { get; set; } =String.Empty;
        public string LastName { get; set; } = String.Empty;
        public bool IsClockedIn { get; set; } = false;

    }
}
