using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.Librarycase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Handlers
{
    public class UpdateLibraryCommandHandler : IRequestHandler<UpdateLibraryCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public UpdateLibraryCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(UpdateLibraryCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.Libraries.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (res == null) 
            {
                return false;
            }
           
            res.LibraryNumber = request.LibraryNumber;
            res.LibraryName = request.LibraryName; 
            res.Location = request.Location;

             _appDbContext.Libraries.Update(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
