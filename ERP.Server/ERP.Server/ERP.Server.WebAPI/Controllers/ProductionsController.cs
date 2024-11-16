using ERP.Server.Application.Features.Customers.CreateCustomer;
using ERP.Server.Application.Features.Customers.DeleteCustomerById;
using ERP.Server.Application.Features.Customers.GetAllCustomer;
using ERP.Server.Application.Features.Customers.UpdateCustomer;
using ERP.Server.Application.Features.Depots.CreateDepot;
using ERP.Server.Application.Features.Depots.CreateDepotById;
using ERP.Server.Application.Features.Depots.GetAllDepot;
using ERP.Server.Application.Features.Depots.UpdateDepot;
using ERP.Server.Application.Features.Invoices.CreateInvoice;
using ERP.Server.Application.Features.Invoices.DeleteInvoiceById;
using ERP.Server.Application.Features.Invoices.GetAllInvoice;
using ERP.Server.Application.Features.Invoices.UpdateInvoice;
using ERP.Server.Application.Features.Productions.CreateProduction;
using ERP.Server.Application.Features.Productions.DeleteProductionById;
using ERP.Server.Application.Features.Productions.GetAllProduction;
using ERP.Server.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERPServer.WebAPI.Controllers;

public sealed class ProductionsController : ApiController
{
    public ProductionsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllProductionQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductionCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteProductionByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}