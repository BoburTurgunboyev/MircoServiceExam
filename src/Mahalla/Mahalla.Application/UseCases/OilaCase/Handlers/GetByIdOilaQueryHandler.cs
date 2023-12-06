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
    public class GetByIdOilaQueryHandler : IRequestHandler<GetByIdOilaQuery, Oila>
    {
        private readonly IAppDbConect _appDbConect;

        public GetByIdOilaQueryHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<Oila> Handle(GetByIdOilaQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.Oilas.FirstOrDefaultAsync(x => x.Id == request.Id);
            return res;
            
           
        }
    }
}
