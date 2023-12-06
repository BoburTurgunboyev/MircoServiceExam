using Mahalla.Application.UseCases.MahallaKamitetCase.Commands;
using Mahalla.Application.UseCases.MahallaKamitetCase.Dtos;
using Mahalla.Application.UseCases.MahallaKamitetCase.Queries;
using Mahalla.Application.UseCases.OdamCase.Commands;
using Mahalla.Application.UseCases.OdamCase.Dtos;
using Mahalla.Application.UseCases.OdamCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mahalla.Api.Controllers.OdamControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OdamController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OdamController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]

        public async ValueTask<IActionResult> CreateOdam(OdamDto odamDto)
        {
            var odam = new CreateOdamCommand()
            {
                FirstName = odamDto.FirstName,
                LastName = odamDto.LastName,
                Age= odamDto.Age,
                StreetName= odamDto.StreetName,
                HomeNumber= odamDto.HomeNumber,
                Number= odamDto.Number,
                OdamMale= odamDto.OdamMale,
                OilaId= odamDto.OilaId,
               
            };
            var res = await _mediator.Send(odam);
            return Ok("Cretaed");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllOdam()
        {
            var result = await _mediator.Send(new GetAllOdamQuery());
            return Ok(result);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetByIdOdam(int id)
        {
            var result = await _mediator.Send(new GetByIdOdamQuery() { Id = id });
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateOdam(int id, OdamDto odamDto)
        {
            var odam = new UpdateOdamCommand()
            {
              FirstName = odamDto.FirstName,
              LastName = odamDto.LastName,
              Age = odamDto.Age,
              Number = odamDto.Number,
              HomeNumber = odamDto.HomeNumber,
              StreetName = odamDto.StreetName,
              OdamMale = odamDto.OdamMale,
              OilaId = odamDto.OilaId,
            };

            var res = await _mediator.Send(odam);
            return Ok("Updated");
        }
        [HttpDelete]

        public async ValueTask<IActionResult> DeleteOdam(int id)
        {
            var result = await _mediator.Send(new DeleteOdamCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
