using Library.Aplication.UseCases.Librarycase.Commands;
using Library.Aplication.UseCases.Librarycase.Dtos;
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
    }
}
