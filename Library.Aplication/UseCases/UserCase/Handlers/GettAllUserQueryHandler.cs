using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.UserCase.Queries;
using Library.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.UserCase.Handlers
{
    public class GettAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<User>>
    {
        private readonly IAppDbContext _appDbContext;

        public GettAllUserQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.Users.ToListAsync(cancellationToken);
            return res;
        }
    }
}
