using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.BookCategoryCase.Commands;
using Library.Aplication.UseCases.BookCategoryCase.Dtos;
using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Handler
{
    public class CreateBookCategoryCommandHandler : IRequestHandler<CreateBookCategoryCommand, bool>

    {
        private readonly IAppDbContext _appDbContext;

        public CreateBookCategoryCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateBookCategoryCommand request, CancellationToken cancellationToken)
        {
            var bookcategory = new BookCategory()
            {
                CategoryName = request.CategoryName,
                Block = request.Block,
                LibraryId = request.LibraryId,
            };
            await _appDbContext.BookCategories.AddAsync(bookcategory);  
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
            
        }
    }
}
