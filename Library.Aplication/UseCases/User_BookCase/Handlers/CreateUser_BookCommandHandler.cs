using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.User_BookCase.Commands;
using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Handlers
{
    public class CreateUser_BookCommandHandler : IRequestHandler<CreateUser_BookCommand,bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateUser_BookCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateUser_BookCommand request, CancellationToken cancellationToken)
        {
            var user_book = new User_Book() 
            {
                BookId = request.BookId,
                UserId = request.UserId,
                StatusActive = request.StatusActive,
            };

            await _appDbContext.Users_Books.AddAsync(user_book); 
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
