using Library.Aplication.UseCases.User_BookCase.Commands;
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

    }
}
