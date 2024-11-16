using FluentValidation;

namespace ERP.Server.Application.Features.Products.CreateProduct;

public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.TypeValue).GreaterThan(0);
    }
}
