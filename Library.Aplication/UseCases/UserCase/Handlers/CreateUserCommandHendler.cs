using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.UserCases.Commands;
using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.UserCases.Handler
{
    public class CreateUserCommandHendler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;
        
        public CreateUserCommandHendler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var user = new User()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserAge = request.UserAge,
                UserAdress = request.UserAdress,
                UserName = request.UserName,
                UserPhone = request.UserPhone,
                UserRole = request.UserRole,
                ImageUrl = request.ImageUrl,

            };

            await _appDbContext.Users.AddAsync(user);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
           
        }
    }
}
