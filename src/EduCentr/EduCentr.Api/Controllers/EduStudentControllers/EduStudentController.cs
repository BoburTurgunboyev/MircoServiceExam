using EduCentr.Application.Usecases.EduStudentCase.Commands;
using EduCentr.Application.Usecases.EduStudentCase.Dtos;
using EduCentr.Application.Usecases.EduStudentCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCentr.Api.Controllers.EduStudentControllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class EduStudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EduStudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateEduStudent(EduStudentDto eduStudentDto)
        {
            var student = new CreateEduStudentCommand()
            {
               Firstname = eduStudentDto.Firstname,
               Lastname = eduStudentDto.Lastname,
               Age = eduStudentDto.Age,
               Email = eduStudentDto.Email,
               Phone = eduStudentDto.Phone,
               Categories = eduStudentDto.Categories,   
            };

            await _mediator.Send(student);
            return Ok(eduStudentDto);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetAllEduStudent()
        {
            var res = await _mediator.Send(new GetAllEduStudentQuery());
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdEduStudent(int id)
        {
            var res = await _mediator.Send(new GetByIdEduStudentQuery() { Id = id });
            return Ok(res);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateEduStudent(int id, EduStudentDto eduStudentDto)
        {
            var res = new UpdateEduStudentCommand()
            {
                Firstname=eduStudentDto.Firstname,
                Lastname=eduStudentDto.Lastname,
                Age = eduStudentDto.Age,
                Email = eduStudentDto.Email,
                Phone = eduStudentDto.Phone,
                Categories = eduStudentDto.Categories,  


            };
            await _mediator.Send(res);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteEduStudent(int id)
        {
            var res = await _mediator.Send(new DeleteEduEduStudentCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
