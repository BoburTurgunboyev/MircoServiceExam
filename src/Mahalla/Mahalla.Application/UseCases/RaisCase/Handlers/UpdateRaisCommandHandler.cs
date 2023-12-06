using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.RaisCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.RaisCase.Handlers
{
    public class UpdateRaisCommandHandler : IRequestHandler<UpdateRaisCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public UpdateRaisCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(UpdateRaisCommand request, CancellationToken cancellationToken)
        {
            var rais = await _appDbConect.Raiss.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (rais == null)
            {
                return false;
            }

            rais.FirstName = request.FirstName;
            rais.LastName = request.LastName;
            rais.Email = request.Email; 
            rais.Age = request.Age;
            rais.RaisMale = request.RaisMale;   
            rais.MahallaKamitetId = request.MahallaKamitetId;
            rais.Number = request.Number;

            _appDbConect.Raiss.Remove(rais);
            var relust = await _appDbConect.SaveChangesAsync(cancellationToken);
            return relust > 0;
        }
    }
}
