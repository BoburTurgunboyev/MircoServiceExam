using Mahalla.Application.UseCases.OdamCase.Commands;
using Mahalla.Application.UseCases.OdamCase.Dtos;
using Mahalla.Application.UseCases.OdamCase.Queries;
using Mahalla.Application.UseCases.OilaCase.Commands;
using Mahalla.Application.UseCases.OilaCase.Dtos;
using Mahalla.Application.UseCases.OilaCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mahalla.Api.Controllers.OilaControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OilaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OilaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateOila(OilaDto oilaDto)
        {
            var oila = new CreateOilaCommand()
            {
                
                member = oilaDto.member,
                MahallaKamitetId = oilaDto.MahallaKamitetId
              

            };
            var res = await _mediator.Send(oila);
            return Ok("Cretaed");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllOila()
        {
            var result = await _mediator.Send(new GetAllOilaQuery());
            return Ok(result);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdOila(int id)
        {
            var result = await _mediator.Send(new GetByIdOdamQuery() { Id = id });
            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateOila(int id, OilaDto oilaDto)
        {
            var oila = new UpdateOilaCommand()
            {
               member = oilaDto.member,
               MahallaKamitetId =oilaDto.MahallaKamitetId,
            };

            var res = await _mediator.Send(oila);
            return Ok("Updated");
        }
        [HttpDelete]

        public async ValueTask<IActionResult> DeleteOila(int id)
        {
            var result = await _mediator.Send(new DeleteOilaCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
