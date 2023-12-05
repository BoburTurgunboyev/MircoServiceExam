using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.Librarycase.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Handlers
{
    public class GetByIdLibraryQueryHandler : IRequestHandler<GetByIdLibraryQuery, Domain.Entities.Library>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdLibraryQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Domain.Entities.Library> Handle(GetByIdLibraryQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.Libraries.FirstOrDefaultAsync(x => x.Id == request.Id);
            return res;
        }
    }
}
