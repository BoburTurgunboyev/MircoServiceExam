using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.BookCase.Queries;
using Library.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCase.Handlers
{
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQuery, List<Book>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllBookQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Book>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Books.ToListAsync(cancellationToken);
            return result;
        }
    }
}
