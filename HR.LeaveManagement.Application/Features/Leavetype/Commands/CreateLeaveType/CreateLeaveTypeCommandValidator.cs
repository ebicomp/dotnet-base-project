using System;
using FluentValidation;

namespace HR.LeaveManagement.Application.Features.Leavetype.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommandValidator : AbstractValidator<CreateLeaveTypeCommand>
    {
        public CreateLeaveTypeCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropetyName} is required")
                .NotNull()
                .MaximumLength(70).WithMessage("{PropetyName} must be fewer than 70 characters");

            RuleFor(p => p.DefaultDays)
                .LessThan(100).WithMessage("{PropetyName} cannot exceed 100")
                .GreaterThan(1).WithMessage("{PropetyName} cannot be less than 1");
        }
    }
}

