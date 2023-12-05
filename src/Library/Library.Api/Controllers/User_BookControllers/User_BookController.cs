using Library.Aplication.UseCases.User_BookCase.Commands;
using Library.Aplication.UseCases.User_BookCase.Dtos;
using Library.Aplication.UseCases.User_BookCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers.User_BookControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class User_BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public User_BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateUserBookAsync(CreateUser_BookCommand command)
        {
            var Userbook = new CreateUser_BookCommand()
            {
                BookId = command.BookId,
                UserId = command.UserId,
                StatusActive = command.StatusActive,
            };
            await _mediator.Send(Userbook);
            return Ok(command);

        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllUser_Book()
        {
            var res = await _mediator.Send(new GetAllUser_BookQuery()); 
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdUser_Book(int id)
        {
            var res = await _mediator.Send(new GetByIdUser_BookQuery() { Id = id });
            return Ok(res);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateUser_Book(int id ,User_BookDto user_BookDto)
        {
            var result = new UpdateUser_BookCommand()
            {
                Id = id,
                BookId = user_BookDto.BookId,
                UserId = user_BookDto.UserId,
                StatusActive = user_BookDto.StatusActive,


            };
             await _mediator.Send(result);
            return Ok("Updated"); 
        }
        [HttpDelete]

        public async ValueTask<IActionResult> DeleteUser_Book(int id)
        {
            var res = await _mediator.Send( new DeleteUser_BookCommand() { Id = id});
            return Ok("Deleted");
        }

    }
}
