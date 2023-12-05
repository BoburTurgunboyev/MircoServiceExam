using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.Librarycase.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Handlers
{
    public class GetAllLibraryQueryHandler : IRequestHandler<GetAllLibraryQuery, List<Domain.Entities.Library>>
    {
        private readonly IAppDbContext _appDbContext;

        public GetAllLibraryQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Domain.Entities.Library>> Handle(GetAllLibraryQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.Libraries.ToListAsync(cancellationToken);
            return res;
        }
    }
}
