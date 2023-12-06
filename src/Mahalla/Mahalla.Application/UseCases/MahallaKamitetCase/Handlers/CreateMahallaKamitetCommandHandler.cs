using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.MahallaKamitetCase.Commands;
using Mahalla.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.MahallaKamitetCase.Handlers
{
    public class CreateMahallaKamitetCommandHandler : IRequestHandler<CreateMahallaKamitetCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public CreateMahallaKamitetCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(CreateMahallaKamitetCommand request, CancellationToken cancellationToken)
        {
            var mahalla = new MahallaKamitet()
            {
              RegionName = request.RegionName,
              MahallaName = request.MahallaName,
              CityName = request.CityName,
              RaisId= request.RaisId

            };

              await _appDbConect.MahallaKamitets.AddAsync(mahalla);

            var result = await _appDbConect.SaveChangesAsync(cancellationToken);
            return result > 0;
                  
        }
    }
}
