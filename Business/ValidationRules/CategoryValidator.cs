using System;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("Kategori adı boş geçilemez!")
                .MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız!")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız!");
            RuleFor(x => x.CategoryDescription)
                .NotEmpty().WithMessage("Kategori açıklaması boş geçilemez!");
        }
    }
}

