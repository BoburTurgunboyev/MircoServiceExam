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
    public class UpdateUser_BookCommandHandler : IRequestHandler<UpdateUser_BookCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public UpdateUser_BookCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(UpdateUser_BookCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Users_Books.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }

            result.Id = request.Id;
            result.UserId = request.UserId;
            result.BookId = request.BookId;
            result.StatusActive = request.StatusActive;

            _appDbContext.Users_Books.Update(result);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
