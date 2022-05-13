using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClockInClockOut.Data
{
    public class Record
    {
        [Key]
        public int ItemNumber { get; set; }
        

        public int IdNumber { get; set; }
        public string EmployeeName { get; set; }=String.Empty;
        public DateTime ClockInTime { get; set; }
        public DateTime ClockOutTime { get; set; }
        public double TotalHoursWorked { get; set; }

}
}
