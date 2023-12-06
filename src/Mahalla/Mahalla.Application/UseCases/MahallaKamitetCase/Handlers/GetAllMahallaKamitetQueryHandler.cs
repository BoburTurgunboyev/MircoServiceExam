using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.MahallaKamitetCase.Queries;
using Mahalla.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.MahallaKamitetCase.Handlers
{
    public class GetAllMahallaKamitetQueryHandler : IRequestHandler<GetAllMahallaKamitetQuery, List<MahallaKamitet>>
    {
        private readonly IAppDbConect _appDbConect;

        public GetAllMahallaKamitetQueryHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<List<MahallaKamitet>> Handle(GetAllMahallaKamitetQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.MahallaKamitets.ToListAsync(cancellationToken);
            return res;
        }
    }
}
