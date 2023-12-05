using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.BookCategoryCase.Queries;
using Library.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Handlers
{
    public class GetAllBookCategoryQueryHandler : IRequestHandler<GetAllBookCategoryQuery, List<BookCategory>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllBookCategoryQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<BookCategory>> Handle(GetAllBookCategoryQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.BookCategories.ToListAsync(cancellationToken);
            return res;
        }
    }
}
