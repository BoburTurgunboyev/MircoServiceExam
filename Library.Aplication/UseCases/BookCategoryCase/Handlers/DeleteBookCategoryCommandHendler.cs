using Library.Aplication.Absreactions;
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
    public class DeleteBookCategoryCommandHendler : IRequestHandler<DeleteBookCategoryCommand,bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteBookCategoryCommandHendler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteBookCategoryCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.BookCategories.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }

            _appDbContext.BookCategories.Remove(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
