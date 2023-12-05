using Library.Aplication.UseCases.BookCase.Queries;
using Library.Aplication.UseCases.Librarycase.Commands;
using Library.Aplication.UseCases.Librarycase.Dtos;
using Library.Aplication.UseCases.Librarycase.Queries;
using Library.Aplication.UseCases.UserCase.Commands;
using Library.Aplication.UseCases.UserCase.Queries;
using Library.Aplication.UseCases.UserCases.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers.LibraryContollers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LibraryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateLibrary(LibraryDto libraryDto)
        {
            var library = new CreateLibraryCommand()
            {
                LibraryName = libraryDto.LibraryName,
                LibraryNumber = libraryDto.LibraryNumber,
                Location = libraryDto.Location,
            };
            await _mediator.Send(library);
            return Ok(libraryDto);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllLibrary()
        {
            var result = await _mediator.Send(new GetAllLibraryQuery());
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdLibrary(int id)
        {
            var res = await _mediator.Send(new GetByIdLibraryQuery() { Id = id });
            return Ok(res);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateaLibrary(int id, LibraryDto libraryDto )
        {
            var res = new UpdateLibraryCommand()
            {
                Id=id,
                LibraryName=libraryDto.LibraryName,
                LibraryNumber=libraryDto.LibraryNumber,
                Location=libraryDto.Location,
            
            };
            await _mediator.Send(res);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteLibrary(int id)
        {
            await _mediator.Send(new DeleteLibraryCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
