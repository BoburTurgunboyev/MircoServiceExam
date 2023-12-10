using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Application.UseCases.ExamResultsCase.Commands;
using University.Application.UseCases.ExamResultsCase.Dtos;
using University.Application.UseCases.ExamResultsCase.Queries;
using University.Application.UseCases.StudentsCase.Commands;
using University.Application.UseCases.StudentsCase.Dtos;
using University.Application.UseCases.StudentsCase.Queries;

namespace University.Api.Controllers.StudentsControllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateStudents(StudentDto studentDto)
        {
            var exem = new CreateStudentsCommand()
            {
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                Studentsss = studentDto.Studentsss,
                
           
            };
            var res = await _mediator.Send(exem);
            return Ok("Cretaed");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllStudents()
        {
            var result = await _mediator.Send(new GettAllStudentsQuery());
            return Ok(result);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetByIdStudents(int id)
        {
            var result = await _mediator.Send(new GetByIdStudentsQuery() { Id = id });
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateStudents(int id,StudentDto studentDto)
        {
            var exem = new UpdateStudentsCommand()
            {
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
            
            };

            var res = await _mediator.Send(exem);
            return Ok("Updated");
        }
        [HttpDelete]

        public async ValueTask<IActionResult> DeleteStudents(int id)
        {
            var result = await _mediator.Send(new DeleteStudentsCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
