using System;
using MediatR;

namespace HR.LeaveManagement.Application.Features.Leavetype.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypeDetailsQuery : IRequest<LeaveTypeDetailDto>
    {
        public int Id { get; set; }
    }
}

