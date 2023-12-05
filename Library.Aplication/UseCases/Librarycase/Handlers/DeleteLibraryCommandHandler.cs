using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.Librarycase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Handlers
{
    public class DeleteLibraryCommandHandler : IRequestHandler<DeleteLibraryCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteLibraryCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(DeleteLibraryCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.Libraries.FirstOrDefaultAsync(x => x.Id == request.Id);   
            if (res == null)
            {
                return false;
            }

            _appDbContext.Libraries.Remove(res);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
