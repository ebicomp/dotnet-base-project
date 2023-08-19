using MediatR;

namespace HR.LeaveManagement.Application.Features.Leavetype.Queries.GetAllLeaveTypes;

public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
{

}

