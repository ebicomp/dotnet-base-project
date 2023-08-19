using System;
namespace HR.LeaveManagement.Application.Features.Leavetype.Queries.GetLeaveTypeDetails
{
    public class LeaveTypeDetailDto
    {
        public LeaveTypeDetailDto()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}

