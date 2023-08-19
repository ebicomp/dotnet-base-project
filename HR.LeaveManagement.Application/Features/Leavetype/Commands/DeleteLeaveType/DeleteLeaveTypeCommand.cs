using System;
using MediatR;

namespace HR.LeaveManagement.Application.Features.Leavetype.Commands.DeleteLeaveType;

public class DeleteLeaveTypeCommand : IRequest<Unit>
{
    public int Id { get; set; }
}

