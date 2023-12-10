using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.MahallaKamitetCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.MahallaKamitetCase.Handlers
{
    public class UpdateMahallaKomitetCommandHandler : IRequestHandler<UpdateMahallaKomitetCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public UpdateMahallaKomitetCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(UpdateMahallaKomitetCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbConect.MahallaKamitets.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }
           
            result.MahallaName = request.MahallaName;
            result.RegionName = request.RegionName;
            result.CityName = request.CityName;
           

            _appDbConect.MahallaKamitets.Update(result);
            var res = await _appDbConect.SaveChangesAsync(cancellationToken);
            return res > 0; 
        }
    }
}
