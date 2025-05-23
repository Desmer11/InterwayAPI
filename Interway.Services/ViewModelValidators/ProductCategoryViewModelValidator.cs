using FluentValidation;
using InterwayAPI.ViewModels.Models;

namespace InterwayAPI.Services.ViewModelValidators
{
    public class ProductCategoryViewModelValidator : AbstractValidator<ProductCategoryViewModel>
    {
        public ProductCategoryViewModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Cannot insert category without name. Please enter name");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Name must contain maximum 30 characters");
        }
    }
}
