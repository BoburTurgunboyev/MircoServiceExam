using Library.Aplication.Interface.File;
using Library.Aplication.UseCases.UserCase.Commands;
using Library.Aplication.UseCases.UserCase.Queries;
using Library.Aplication.UseCases.UserCases.Commands;
using Library.Aplication.UseCases.UserCases.Dtos;
using Library.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Library.Api.Controllers.UserControllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IFileService _fileService;

        public UserController(IMediator mediator, IFileService fileService = null)
        {
            _mediator = mediator;
            _fileService = fileService;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateUser([FromForm]UserDto userDto)
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
                ImageUrl = userDto.ImageUrl,

            };

            await _mediator.Send(user);
            return Ok(userDto);

           
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllUser()
        {
            var res = await _mediator.Send(new GetAllUserQuery());
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdUser(int id)
        {
            var res = await _mediator.Send(new GetByIdUserQuery() { Id = id });
            return Ok(res);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateUser(int id ,[FromForm]UserDto userDto) 
        {
            var res = new UpdateUserCommand()
            {
                Id = id,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                UserName = userDto.UserName,
                UserAge = userDto.UserAge,
                Email = userDto.Email,
                UserAdress = userDto.UserAdress,
                UserPhone = userDto.UserPhone,
                UserRole = userDto.UserRole,
                ImageUrl = userDto.ImageUrl,

            };
            await _mediator.Send(res);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteUser(int id) 
        {
            var res = await _mediator.Send(new DeleteUserCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
