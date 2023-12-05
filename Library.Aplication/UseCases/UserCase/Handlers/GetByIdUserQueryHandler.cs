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
    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, User>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdUserQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            return res;
        }
    }
}
