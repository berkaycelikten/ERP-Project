using ERP.Server.Application.Features.Customers.CreateCustomer;
using ERP.Server.Application.Features.Customers.DeleteCustomerById;
using ERP.Server.Application.Features.Customers.GetAllCustomer;
using ERP.Server.Application.Features.Customers.UpdateCustomer;
using ERP.Server.Application.Features.Depots.CreateDepot;
using ERP.Server.Application.Features.Depots.CreateDepotById;
using ERP.Server.Application.Features.Depots.GetAllDepot;
using ERP.Server.Application.Features.Depots.UpdateDepot;
using ERP.Server.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERPServer.WebAPI.Controllers;

public sealed class DepotsController : ApiController
{
    public DepotsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllDepotQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDepotCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteDepotByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateDepotCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}