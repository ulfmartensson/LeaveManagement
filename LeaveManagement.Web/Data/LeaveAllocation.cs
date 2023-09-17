﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeID")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeID { get; set; }
        public string? EmployeeID { get; set; }
    }
}
