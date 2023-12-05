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
    public class GetAllUser_BookQueryHandler : IRequestHandler<GetAllUser_BookQuery, List<User_Book>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllUser_BookQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<User_Book>> Handle(GetAllUser_BookQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.Users_Books.ToListAsync(cancellationToken);
            return res;
        }
    }
}
