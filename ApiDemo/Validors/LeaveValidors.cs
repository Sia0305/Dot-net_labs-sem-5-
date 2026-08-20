using FluentValidation;
using ApiDemo.DTO;

namespace ApiDemo.Validors
{
    // Validator for LeaveDTO - used for UPDATE
    public class LeaveValidator : AbstractValidator<LeaveDTO>
    {
        public LeaveValidator()
        {
            // Employee name is required
            RuleFor(x => x.EmployeeName)
                .NotEmpty()
                .WithMessage("Employee name is required.");

            // Leave type must be casual, sick, or earned
            RuleFor(x => x.LeaveType)
                .NotEmpty()
                .WithMessage("Leave type is required.")
                .Must(type => new[] { "casual", "sick", "earned" }
                    .Contains(type.ToLower()))
                .WithMessage("Leave type must be either 'casual', 'sick', or 'earned'.");

            // From date must be earlier than To date
            RuleFor(x => x.FromDate)
                .LessThan(x => x.ToDate)
                .WithMessage("From date must be earlier than To date.");

            // Total leave duration must not exceed 10 days
            RuleFor(x => x.TotalLeaveDuration)
                .GreaterThan(0)
                .WithMessage("Total leave duration must be greater than 0.")
                .LessThanOrEqualTo(10)
                .WithMessage("Total leave duration must not exceed 10 days.");

            // Reason must contain at least 10 characters
            RuleFor(x => x.Reason)
                .NotEmpty()
                .WithMessage("Reason is required.")
                .MinimumLength(10)
                .WithMessage("Reason must contain at least 10 characters.");
        }
    }


    // Validator for CreateLeaveDTO - used for INSERT
    public class CreateLeaveDTOValidator : AbstractValidator<CreateLeaveDTO>
    {
        public CreateLeaveDTOValidator()
        {
            // Employee ID is required
            RuleFor(x => x.EmployeeId)
                .GreaterThan(0)
                .WithMessage("Employee ID is required.");

            // Employee name is required
            RuleFor(x => x.EmployeeName)
                .NotEmpty()
                .WithMessage("Employee name is required.");

            // Leave type must be casual, sick, or earned
            RuleFor(x => x.LeaveType)
                .NotEmpty()
                .WithMessage("Leave type is required.")
                .Must(type => new[] { "casual", "sick", "earned" }
                    .Contains(type.ToLower()))
                .WithMessage("Leave type must be either 'casual', 'sick', or 'earned'.");

            // From date is required
            RuleFor(x => x.FromDate)
                .NotEmpty()
                .WithMessage("From date is required.");

            // To date is required and must be after From date
            RuleFor(x => x.ToDate)
                .NotEmpty()
                .WithMessage("To date is required.")
                .GreaterThan(x => x.FromDate)
                .WithMessage("To date must be later than From date.");

            // Total leave duration
            RuleFor(x => x.TotalLeaveDuration)
                .GreaterThan(0)
                .WithMessage("Total leave duration must be greater than 0.")
                .LessThanOrEqualTo(10)
                .WithMessage("Total leave duration must not exceed 10 days.");

            // Reason must contain at least 10 characters
            RuleFor(x => x.Reason)
                .NotEmpty()
                .WithMessage("Reason is required.")
                .MinimumLength(10)
                .WithMessage("Reason must contain at least 10 characters.");
        }
    }
}