namespace ApiDemo.DTO
{
    public class LeaveDTO
    {
        public int LeaveID { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } 
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int TotalLeaveDuration { get; set; }
        public string Reason { get; set; }
    }
    public class CreateLeaveDTO
    {        
        public int LeaveID { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } 
        public string LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int TotalLeaveDuration { get; set; }
        public string Reason { get; set; }
    }
}
