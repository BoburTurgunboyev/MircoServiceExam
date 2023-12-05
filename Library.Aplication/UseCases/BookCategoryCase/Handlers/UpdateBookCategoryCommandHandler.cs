using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.BookCase.Commands;
using Library.Aplication.UseCases.BookCategoryCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Handlers
{
    public class UpdateBookCategoryCommandHandler : IRequestHandler<UpdateBookCategoryCommand, bool>
    {
           private readonly IAppDbContext _appDbContext;

        public UpdateBookCategoryCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(UpdateBookCategoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.BookCategories.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }

            result.Id = request.Id;
            result.CategoryName = request.CategoryName;
            result.Block= request.Block;
            result.LibraryId = request.LibraryId;   



            _appDbContext.BookCategories.Update(result);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
