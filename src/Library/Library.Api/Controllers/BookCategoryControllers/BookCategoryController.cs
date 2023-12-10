using Library.Aplication.UseCases.BookCase.Commands;
using Library.Aplication.UseCases.BookCategoryCase.Commands;
using Library.Aplication.UseCases.BookCategoryCase.Dtos;
using Library.Aplication.UseCases.BookCategoryCase.Queries;
using Library.Aplication.UseCases.UserCase.Commands;
using Library.Aplication.UseCases.UserCase.Queries;
using Library.Aplication.UseCases.UserCases.Commands;
using Library.Aplication.UseCases.UserCases.Dtos;
using Library.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers.BookCategoryControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateBookCategory(BookCategoryDto bookCategoryDto)
        {
            var bookcategory = new CreateBookCategoryCommand()
            {
                CategoryName = bookCategoryDto.CategoryName,
                Block = bookCategoryDto.Block,
                LibraryId = bookCategoryDto.LibraryId,
            };

            await _mediator.Send(bookcategory);
            return Ok(bookCategoryDto);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetAllBookCategory()
        {
            var res = await _mediator.Send(new GetAllBookCategoryQuery());
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdBookCategory(int id)
        {
            var res = await _mediator.Send(new GetByIdBookCategoryQuery() {Id=id});
            return Ok(res);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateBookCategory(int id, BookCategoryDto bookCategoryDto)
        {
            var res = new UpdateBookCategoryCommand()
            {
                Id = id,
                CategoryName = bookCategoryDto.CategoryName,
                Block = bookCategoryDto.Block,
                LibraryId = bookCategoryDto.LibraryId,
             

            };
            await _mediator.Send(res);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteBookCategory(int id)
        {
            var res = await _mediator.Send(new DeleteBookCategoryCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
