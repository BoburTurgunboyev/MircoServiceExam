using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.User_BookCase.Queries;
using Library.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Handlers
{
    public class GetByIdUser_BookQueryHandler : IRequestHandler<GetByIdUser_BookQuery, User_Book>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdUser_BookQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User_Book> Handle(GetByIdUser_BookQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Users_Books.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
           
        }
    }
}
