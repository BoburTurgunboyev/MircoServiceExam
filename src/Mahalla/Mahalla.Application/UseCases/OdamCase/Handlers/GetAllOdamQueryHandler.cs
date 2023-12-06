using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.OdamCase.Queries;
using Mahalla.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OdamCase.Handlers
{
    public class GetAllOdamQueryHandler : IRequestHandler<GetAllOdamQuery, List<Odam>>
    {
        private readonly IAppDbConect _appDbConect;

        public GetAllOdamQueryHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<List<Odam>> Handle(GetAllOdamQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.Odams.ToListAsync(cancellationToken);
            return res;
        }
    }
}
