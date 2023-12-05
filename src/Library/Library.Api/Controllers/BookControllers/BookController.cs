
using Library.Aplication.UseCases.BookCase.Commands;
using Library.Aplication.UseCases.BookCase.Queries;
using Library.Aplication.UseCases.UserCases.Commands;
using Library.Aplication.UseCases.UserCases.Dtos;
using Library.Domain.Entities;
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

        [HttpGet]

        public async ValueTask<IActionResult> GetAllBooks()
        {
            var result = await _mediator.Send(new GetAllBookQuery());
            return Ok(result);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetByIdBook(int id)
        {
            var result=await _mediator.Send(new GetByIdBookQuery() { Id = id });
            return Ok(result);
        }


        [HttpPut]

        public async ValueTask<IActionResult> UpdateBook(int id, BookDto bookDto)
        {
            var result = new UpdateBookCommand()
            {
                Id = id,
                Title = bookDto.Title,
                PublishPlace = bookDto.PublishPlace,
                DatePublished = bookDto.DatePublished,
                BookCategoryId = bookDto.BookCategoryId,
            };

            var res =await _mediator.Send(result);
            return Ok("updated");
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteBook(int id)
        {
            var result = await _mediator.Send(new DeleteBookCommand { Id = id });
            return Ok("deleted");
        }
    }
}
