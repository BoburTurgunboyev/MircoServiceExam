using Library.Aplication.Absreactions;
using Library.Aplication.Interface.File;
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
        private readonly IFileService _fileService;

        public CreateUserCommandHendler(IAppDbContext appDbContext, IFileService fileService)
        {
            _appDbContext = appDbContext;
            _fileService = fileService;
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
                ImageUrl = await _fileService.UploadImageAsync(request.ImageUrl),

            };

            await _appDbContext.Users.AddAsync(user);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
           
        }
    }
}
