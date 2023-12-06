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
    public class GetByIdOdamQueryHandler : IRequestHandler<GetByIdOdamQuery, Odam>
    {
        private readonly IAppDbConect _appDbConect;

        public GetByIdOdamQueryHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async  Task<Odam> Handle(GetByIdOdamQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbConect.Odams.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
