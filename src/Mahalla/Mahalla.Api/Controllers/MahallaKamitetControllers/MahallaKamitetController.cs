using Mahalla.Application.UseCases.MahallaKamitetCase.Commands;
using Mahalla.Application.UseCases.MahallaKamitetCase.Dtos;
using Mahalla.Application.UseCases.MahallaKamitetCase.Queries;
using Mahalla.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mahalla.Api.Controllers.MahallaKamitetControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MahallaKamitetController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MahallaKamitetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateMahallaKamitet(MahallaKamitetDto mahallaKamitetDto)
        {
            var mahalla = new CreateMahallaKamitetCommand()
            {
                MahallaName = mahallaKamitetDto.MahallaName,
                RegionName = mahallaKamitetDto.RegionName,
                CityName = mahallaKamitetDto.CityName,
                RaisId =mahallaKamitetDto.RaisId
            };
            var res= await _mediator.Send(mahalla);
            return Ok("Cretaed");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllMahallaKamitet()
        {
            var result = await _mediator.Send(new GetAllMahallaKamitetQuery());
            return Ok(result);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetByIdMahallaKamitet(int id)
        {
            var result = await _mediator.Send(new GetByIdMahallaKomitetQuery() { Id = id});
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateMahallaKamitet(int id,MahallaKamitetDto mahallaKamitetDto)
        {
            var mahalla = new UpdateMahallaKomitetCommand()
            {
                Id = id,
                MahallaName = mahallaKamitetDto.MahallaName,
                CityName = mahallaKamitetDto.CityName,
                RegionName = mahallaKamitetDto.RegionName,
                RaisId = mahallaKamitetDto.RaisId
            };

            var res = await _mediator.Send(mahalla);
            return Ok("Updated");
        }
        [HttpDelete]

        public async ValueTask<IActionResult> DeleteMahallaKamitet(int id)
        {
            var result = await _mediator.Send(new DeleteMahallaKamitetCommand() { Id = id });   
            return Ok("Deleted");
        }
    }
}
