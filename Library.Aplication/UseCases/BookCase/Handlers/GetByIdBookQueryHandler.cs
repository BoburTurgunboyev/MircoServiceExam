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
    public class GetByIdBookQueryHandler : IRequestHandler<GetByIdBookQuery, Book>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdBookQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Book> Handle(GetByIdBookQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Books.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
