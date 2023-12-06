using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.OdamCase.Commands;
using Mahalla.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OdamCase.Handlers
{
    public class CreateOdamCommandHandler : IRequestHandler<CreateOdamCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public CreateOdamCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(CreateOdamCommand request, CancellationToken cancellationToken)
        {
            var odam = new Odam()
            {
               
               FirstName = request.FirstName,
               LastName = request.LastName,
               HomeNumber = request.HomeNumber,
               Number = request.Number,
               Age = request.Age,   
               OdamMale = request.OdamMale,
               OilaId = request.OilaId,
               StreetName = request.StreetName,

            };

            await _appDbConect.Odams.AddAsync(odam);

            var result = await _appDbConect.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
