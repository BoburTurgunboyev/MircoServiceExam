using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Application.UseCases.ExamResultsCase.Commands;
using University.Application.UseCases.ExamResultsCase.Dtos;
using University.Application.UseCases.ExamResultsCase.Queries;
using University.Application.UseCases.OverAllMarksCase.Commands;
using University.Application.UseCases.OverAllMarksCase.Dtos;
using University.Application.UseCases.OverAllMarksCase.Queries;

namespace University.Api.Controllers.OverAllMarksControllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class OverAllMarksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OverAllMarksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateOverAllMarks(OverAllMarksDto overAllMarksDto)
        {
            var mark = new CreateOverAllMarksCommand()
            {

              StudentsId = overAllMarksDto.StudentsId,  
              MarkType = overAllMarksDto.MarkType,

            };
            var res = await _mediator.Send(mark);
            return Ok("Cretaed");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllOverAllMarks()
        {
            var result = await _mediator.Send(new GetAllOverAllMarksQuery());
            return Ok(result);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetByIdOverAllMarks(int id)
        {
            var result = await _mediator.Send(new GetByIdOverAllMarksQuery() { Id = id });
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateOverAllMarks(int id, OverAllMarksDto overAllMarksDto)
        {
            var mark = new UpdateOverAllMarksCommand()
            {
                StudentsId= overAllMarksDto.StudentsId,
                MarkType= overAllMarksDto.MarkType,
            };

            var res = await _mediator.Send(mark);
            return Ok("Updated");
        }
        [HttpDelete]

        public async ValueTask<IActionResult> DeleteOverAllMarks(int id)
        {
            var result = await _mediator.Send(new DeleteOverAllMarkscommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
