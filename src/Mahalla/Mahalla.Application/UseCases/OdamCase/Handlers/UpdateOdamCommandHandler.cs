using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.OdamCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OdamCase.Handlers
{
    public class UpdateOdamCommandHandler : IRequestHandler<UpdateOdamCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public UpdateOdamCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(UpdateOdamCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbConect.Odams.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }
           
            result.FirstName = request.FirstName;
            result.LastName = request.LastName;
            result.Age = request.Age;
            result.StreetName = request.StreetName;
            result.Number = request.Number;
            result.HomeNumber = request.HomeNumber;
            result.OdamMale = request.OdamMale;





            _appDbConect.Odams.Update(result);
            var res = await _appDbConect.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
