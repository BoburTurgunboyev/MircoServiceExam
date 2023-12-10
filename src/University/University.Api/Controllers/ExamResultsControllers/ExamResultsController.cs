using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Application.UseCases.ExamResultsCase.Commands;
using University.Application.UseCases.ExamResultsCase.Dtos;
using University.Application.UseCases.ExamResultsCase.Queries;

namespace University.Api.Controllers.ExamResultsControllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class ExamResultsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExamResultsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateExamResults(ExemResultsDto exemResultsDto)
        {
            var exem = new CreateExamResultsCommand()
            {

                ExemMark = exemResultsDto.ExemMark,
                Terms = exemResultsDto.Terms,
                Year = exemResultsDto.Year,
                StudentSubjectId = exemResultsDto.StudentSubjectId,


            };
            var res = await _mediator.Send(exem);
            return Ok("Cretaed");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllExamResults()
        {
            var result = await _mediator.Send(new GetAllExamResultsQuery());
            return Ok(result);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetByIdExamResults(int id)
        {
            var result = await _mediator.Send(new GetByIdExamResultsQuery() { Id = id });
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateExamResults(int id, ExemResultsDto exemResultsDto)
        {
            var exem = new UpdateExemResultsCommand()
            {
                ExemMark =exemResultsDto.ExemMark,
                Terms=exemResultsDto.Terms,
                Year = exemResultsDto.Year,
                StudentSubjectId=exemResultsDto.StudentSubjectId,
            };

            var res = await _mediator.Send(exem);
            return Ok("Updated");
        }
        [HttpDelete]

        public async ValueTask<IActionResult> DeleteExamResults(int id)
        {
            var result = await _mediator.Send(new DeleteExamResultsCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
