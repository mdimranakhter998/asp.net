
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using FluentValidation;

namespace EcommerceUI.Admin.Validators.Gender
{
    public class GenderValidator:AbstractValidator<GenderModel>
    {
        public GenderValidator()
        {
           
            RuleFor(x => x.GenderType).Empty().WithMessage("Gender is required").Matches("^[a-zA-Z]+$").WithMessage("please used only character");

        }

    }
}
