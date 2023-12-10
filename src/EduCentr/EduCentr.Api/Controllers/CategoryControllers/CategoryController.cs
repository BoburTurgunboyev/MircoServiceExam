using EduCentr.Application.Usecases.CategoryCase.Commands;
using EduCentr.Application.Usecases.CategoryCase.Dtos;
using EduCentr.Application.Usecases.CategoryCase.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCentr.Api.Controllers.CategoryControllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateCategory(CategoryDto categoryDto)
        {
            var category = new CreateCategoryCommand()
            {
                EduStudents = categoryDto.EduStudents,

                CategoryName = categoryDto.CategoryName, 
            };

            await _mediator.Send(category);
            return Ok(categoryDto);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetAllCategory()
        {
            var res = await _mediator.Send(new GetAllCategoryQuery());
            return Ok(res);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdCategory(int id)
        {
            var res = await _mediator.Send(new GetByIdCategoryQuery() { Id = id });
            return Ok(res);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateCategory(int id, CategoryDto categoryDto)
        {
            var res = new UpdateCategoryCommand()
            {
                EduStudents = categoryDto.EduStudents,
                CategoryName = categoryDto.CategoryName

            };
            await _mediator.Send(res);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteCategory(int id)
        {
            var res = await _mediator.Send(new DeleteCategoryCommand() { Id = id });
            return Ok("Deleted");
        }
    }
}
