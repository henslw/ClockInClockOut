﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClockInClockOut.Data
{
    public class Employee
    {
        [Key]
        [Range(1000,9999)]
        public int IdNumber { get; set; }

        public string FirstName { get; set; } =String.Empty;

        public string LastName { get; set; } = String.Empty;

        public bool IsClockedIN { get; set; } = false;

    }
}
