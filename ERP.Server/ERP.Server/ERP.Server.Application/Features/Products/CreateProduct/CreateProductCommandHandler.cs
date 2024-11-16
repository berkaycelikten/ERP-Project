using AutoMapper;
using ERP.Server.Domain.Entities;
using ERP.Server.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERP.Server.Application.Features.Products.CreateProduct;

internal sealed class CreateProductCommandHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateProductCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        bool isNameExist=await productRepository.AnyAsync(p=>p.Name==request.Name,cancellationToken);
        if (isNameExist)
        {
            return Result<string>.Failure("Ürün adi daha önce kullanılmış");
        }
        Product product = mapper.Map<Product>(request);
        await productRepository.AddAsync(product,cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Ürün başarıyla oluşturuldu";
    }
}
