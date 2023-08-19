using System;
using AutoMapper;
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
        }
    }
}

