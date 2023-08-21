using System;
using AutoMapper;
using HR.LeaveManagement.Application.Features.Leavetype.Commands.CreateLeaveType;
using HR.LeaveManagement.Application.Features.Leavetype.Commands.UpdateLeaveType;
using HR.LeaveManagement.Application.Features.Leavetype.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.Leavetype.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveTypeDetailDto, LeaveType>().ReverseMap();
            CreateMap<CreateLeaveTypeCommand, LeaveType>().ReverseMap();
            CreateMap<UpdateLeaveTypeCommand, LeaveType>().ReverseMap();

        }
    }
}

