using System.ComponentModel.DataAnnotations;

namespace ApiDemo.Models
{
    public class LeaveModel
    {
        [Key]
        public int LeaveId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } 
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int TotalLeaveDuration { get; set; }
        public string Reason { get; set; }

    }
}
