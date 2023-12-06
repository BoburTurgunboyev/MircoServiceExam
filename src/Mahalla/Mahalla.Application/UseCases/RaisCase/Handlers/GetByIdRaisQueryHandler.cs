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
    public class GetByIdRaisQueryHandler : IRequestHandler<GetByIdRaisQuery, Rais>
    {
        private readonly IAppDbConect _appDbConect;

        public GetByIdRaisQueryHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<Rais> Handle(GetByIdRaisQuery request, CancellationToken cancellationToken)
        {
            var result  = await _appDbConect.Raiss.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
