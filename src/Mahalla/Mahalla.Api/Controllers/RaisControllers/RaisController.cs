using Mahalla.Application.UseCases.RaisCase.Commands;
using Mahalla.Application.UseCases.RaisCase.Dtos;
using Mahalla.Application.UseCases.RaisCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mahalla.Api.Controllers.RaisControllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class RaisController : ControllerBase
{
    private readonly IMediator _mediator;

    public RaisController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]

    public async ValueTask<IActionResult> CreateRais(RaisDto raisDto)
    {
        var rais = new CreateRaisCommand()
        {
            FirstName = raisDto.FirstName,
            LastName = raisDto.LastName,
            Age = raisDto.Age,
            Number = raisDto.Number,
            Email = raisDto.Email,
            RaisMale = raisDto.RaisMale,
            MahallaKamitetId = raisDto.MahallaKamitetId

        };
        var res = await _mediator.Send(rais);
        return Ok("Cretaed");
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllRais()
    {
        var result = await _mediator.Send(new GetAllRaisQuery());
        return Ok(result);
    }
    [HttpGet]

    public async ValueTask<IActionResult> GetByIRais(int id)
    {
        var result = await _mediator.Send(new GetByIdRaisQuery() { Id = id });
        return Ok(result);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateOila(int id, RaisDto raisDto)
    {
        var rais = new UpdateRaisCommand()
        {
            FirstName = raisDto.FirstName,
            LastName = raisDto.LastName,
            Email = raisDto.Email,
            Age = raisDto.Age,
            MahallaKamitetId = raisDto.MahallaKamitetId,
            Number = raisDto.Number,
            RaisMale = raisDto.RaisMale
        };

        var res = await _mediator.Send(rais);
        return Ok("Updated");
    }
    [HttpDelete]

    public async ValueTask<IActionResult> DeleteOila(int id)
    {
        var result = await _mediator.Send(new DeleteRaisCommand() { Id = id });
        return Ok("Deleted");
    }
}
