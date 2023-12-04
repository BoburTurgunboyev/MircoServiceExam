using Library.Aplication.UseCases.UserCases.Commands;
using Library.Aplication.UseCases.UserCases.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers.UserControllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateUser(UserDto userDto)
        {
            var user = new CreateUserCommand()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                UserName = userDto.UserName,
                UserAge = userDto.UserAge,
                UserAdress = userDto.UserAdress,
                UserPhone = userDto.UserPhone,
                Email = userDto.Email,
                UserRole = userDto.UserRole,

            };

            await _mediator.Send(user);
            return Ok(userDto);
        }
    }
}
