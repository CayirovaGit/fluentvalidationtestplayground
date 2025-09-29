using FluentValidation;
using fluentvalidationtestplayground.Dtos.Customer;

namespace fluentvalidationtestplayground.Validators.Customer
{
    public class CreateCustomerValidator:AbstractValidator<CreateCustomerDto>
   
    {
        public CreateCustomerValidator()
        {
            // Name
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required message.")
                .MinimumLength(2).WithMessage("Name must be at least 2 characters long.")
                .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");

            // Surname
            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname is required message.")
                .MinimumLength(2).WithMessage("Surname must be at least 2 characters long.")
                .MaximumLength(50).WithMessage("Surname must not exceed 50 characters.");

            // Tc (Turkish Identity Number)
            RuleFor(x => x.Tc)
                .NotEmpty().WithMessage("Turkish Identity Number is required.")
                .Matches(@"^\d{11}$").WithMessage("Turkish Identity Number must be exactly 11 digits.");

            // Phone
            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^\+?\d{10,15}$").WithMessage("Invalid phone number format. Use 10–15 digits, optional '+' at the beginning.");

            // Username
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username is required.")
                .MinimumLength(4).WithMessage("Username must be at least 4 characters long.")
                .MaximumLength(20).WithMessage("Username must not exceed 20 characters.");

            // Notes (optional)
            RuleFor(x => x.Notes)
                .MaximumLength(500).WithMessage("Notes must not exceed 500 characters.");

            // VatId (optional)
            RuleFor(x => x.VatId)
                .MaximumLength(50).WithMessage("VAT ID must not exceed 50 characters.");

            // LastContactDate
            RuleFor(x => x.LastContactDate)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Last contact date cannot be in the future.");

            
        }

    }
}
