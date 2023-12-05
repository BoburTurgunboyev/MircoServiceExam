using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.User_BookCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Handlers
{
    public class DeleteUser_BookCommandHandler : IRequestHandler<DeleteUser_BookCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteUser_BookCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteUser_BookCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Users_Books.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }
            _appDbContext.Users_Books.Remove(result);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
