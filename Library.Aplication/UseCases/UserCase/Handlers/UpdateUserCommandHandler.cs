using Library.Aplication.Absreactions;
using Library.Aplication.Interface.File;
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
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly IFileService _fileService;
        public UpdateUserCommandHandler(IAppDbContext appDbContext, IFileService fileService)
        {
            _appDbContext = appDbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            result.Id = request.Id;
            result.FirstName = request.FirstName;
            result.LastName = request.LastName;
            result.UserName = result.UserName;
            result.UserAdress = request.UserAdress;
            result.Email = request.Email;
            result.UserPhone = request.UserPhone;   
            result.UserRole = request.UserRole; 
            result.UserAge = request.UserAge;
            result.ImageUrl = await _fileService.UploadImageAsync(request.ImageUrl);

            _appDbContext.Users.Update(result);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res>0;

        }

    }
}
