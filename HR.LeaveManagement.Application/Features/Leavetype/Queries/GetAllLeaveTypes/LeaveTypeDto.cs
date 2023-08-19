using System;
namespace HR.LeaveManagement.Application.Features.Leavetype.Queries.GetAllLeaveTypes
{
    public class LeaveTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}

