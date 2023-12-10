using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Application.UseCases.ExamResultsCase.Commands;
using University.Application.UseCases.ExamResultsCase.Dtos;
using University.Application.UseCases.ExamResultsCase.Queries;
using University.Application.UseCases.SubjectsCase.Commands;
using University.Application.UseCases.SubjectsCase.Dtos;
using University.Application.UseCases.SubjectsCase.Queries;

namespace University.Api.Controllers.SubjectsControllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]

        public async ValueTask<IActionResult> CreateSubjects(SubjectsDto subjectsDto)
        {
            var exem = new CreateSubjectsCommand()
            {
               SubjectName = subjectsDto.SubjectName,
               Subjects = subjectsDto.Subjects  
               
            };
            var res = await _mediator.Send(exem);
            return Ok("Cretaed");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllSubjects()
        {
            var result = await _mediator.Send(new GetAllSubjectsQuery());
            return Ok(result);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetByIdSubjects(int id)
        {
            var result = await _mediator.Send(new GetByIdSubjectsQuery() { Id = id });
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateSubjects(int id, SubjectsDto subjectsDto)
        {
            var exem = new UpdateSubjectsCommand()
            {
                SubjectName = subjectsDto.SubjectName  
            };

            var res = await _mediator.Send(exem);
            return Ok("Updated");
        }
        [HttpDelete]

        public async ValueTask<IActionResult> DeleteSubjects(int id)
        {
            var result = await _mediator.Send(new DeleteSubjectsCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
