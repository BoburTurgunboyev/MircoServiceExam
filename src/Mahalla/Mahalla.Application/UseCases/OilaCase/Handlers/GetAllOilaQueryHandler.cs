using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.OilaCase.Queries;
using Mahalla.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OilaCase.Handlers
{
    public class GetAllOilaQueryHandler : IRequestHandler<GetAllOilaQuery, List<Oila>>
    {
        private readonly IAppDbConect _appDbConect;

        public GetAllOilaQueryHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<List<Oila>> Handle(GetAllOilaQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.Oilas.ToListAsync(cancellationToken);
            return res;
        }
    }
}
