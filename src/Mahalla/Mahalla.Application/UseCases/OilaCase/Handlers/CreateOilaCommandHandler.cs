using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.OilaCase.Commands;
using Mahalla.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OilaCase.Handlers
{
    public class CreateOilaCommandHandler : IRequestHandler<CreateOilaCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public CreateOilaCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(CreateOilaCommand request, CancellationToken cancellationToken)
        {
            var oila = new Oila()
            {
                Id = request.Id,
                member = request.member,
                MahallaKamitetId =request.MahallaKamitetId,

            };

            _appDbConect.Oilas.Add(oila);
            var res= await _appDbConect.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
