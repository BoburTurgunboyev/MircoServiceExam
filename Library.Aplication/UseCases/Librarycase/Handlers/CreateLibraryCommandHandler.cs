using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.Librarycase.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Handlers
{
    public class CreateLibraryCommandHandler : IRequestHandler<CreateLibraryCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateLibraryCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateLibraryCommand request, CancellationToken cancellationToken)
        {
            var library = new Domain.Entities.Library()
            {
                LibraryName = request.LibraryName,
                LibraryNumber = request.LibraryNumber,
                Location = request.Location,
            };

            await _appDbContext.Libraries.AddAsync(library);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
