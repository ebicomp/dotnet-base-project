using System;
using MediatR;

namespace HR.LeaveManagement.Application.Features.Leavetype.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}

