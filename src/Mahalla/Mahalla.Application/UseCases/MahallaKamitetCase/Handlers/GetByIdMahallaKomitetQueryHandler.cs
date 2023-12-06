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
    public class GetByIdMahallaKomitetQueryHandler : IRequestHandler<GetByIdMahallaKomitetQuery, MahallaKamitet>
    {
        private readonly IAppDbConect _appDbConect;

        public GetByIdMahallaKomitetQueryHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<MahallaKamitet> Handle(GetByIdMahallaKomitetQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbConect.MahallaKamitets.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
