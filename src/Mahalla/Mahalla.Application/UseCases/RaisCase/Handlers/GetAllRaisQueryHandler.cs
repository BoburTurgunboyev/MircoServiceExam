using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.RaisCase.Queries;
using Mahalla.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.RaisCase.Handlers
{
    public class GetAllRaisQueryHandler : IRequestHandler<GetAllRaisQuery, List<Rais>>
    {
        private readonly IAppDbConect _appDbConect;

        public GetAllRaisQueryHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<List<Rais>> Handle(GetAllRaisQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.Raiss.ToListAsync(cancellationToken);
            return res;
        }
    }
}
