
using Library.Aplication.UseCases.UserCases.Commands;
using Library.Aplication.UseCases.UserCases.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers.UserControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        { 
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateBook(BookDto bookDto)
        {
            var res = new CreateBookCommand()
            {
                DatePublished = bookDto.DatePublished,
                BookCategoryId = bookDto.BookCategoryId,
                Title = bookDto.Title,
                PublishPlace = bookDto.PublishPlace,

            };
            await _mediator.Send(res);
            return Ok(bookDto);
        }
    }
}
