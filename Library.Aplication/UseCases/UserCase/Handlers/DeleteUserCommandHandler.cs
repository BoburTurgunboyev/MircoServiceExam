using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.UserCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.UserCase.Handlers
{
    public class DeleteUserCommandHandler:IRequestHandler<DeleteUserCommand,bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteUserCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }

             _appDbContext.Users.Remove(result);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res>0;
        }
    }
}
