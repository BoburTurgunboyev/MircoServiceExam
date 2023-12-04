using Library.Aplication.UseCases.BookCategoryCase.Commands;
using Library.Aplication.UseCases.BookCategoryCase.Dtos;
using Library.Aplication.UseCases.UserCases.Commands;
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
            return Ok(bookcategory);
        }
    }
}
