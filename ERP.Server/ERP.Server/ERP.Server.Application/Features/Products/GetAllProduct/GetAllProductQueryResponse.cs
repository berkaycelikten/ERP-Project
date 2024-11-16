using ERP.Server.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Server.Application.Features.Products.GetAllProduct;

public sealed record GetAllProductQueryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ProductTypeEnum Type { get; set; } = ProductTypeEnum.Product;
    public decimal Stock { get; set; }
}