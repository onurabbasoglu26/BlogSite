using System;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
	public class BlogValidator : AbstractValidator<Blog>
	{
		public BlogValidator()
		{
            RuleFor(x => x.BlogTitle)
                .NotEmpty().WithMessage("Blog başlığı boş geçilemez!")
                .MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız!")
                .MaximumLength(150).WithMessage("Lütfen en fazla 150 karakter girişi yapınız!");
            RuleFor(x => x.BlogImage)
                .NotEmpty().WithMessage("Blog görseli boş geçilemez!");
            RuleFor(x => x.BlogContent).
                NotEmpty().WithMessage("Blog İçeriği Boş Geçilemez")
                .MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız!");
        }
	}
}

