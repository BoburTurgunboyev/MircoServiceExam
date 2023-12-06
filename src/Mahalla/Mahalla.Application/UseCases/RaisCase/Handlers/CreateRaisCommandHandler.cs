using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.RaisCase.Commands;
using Mahalla.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.RaisCase.Handlers
{
    public class CreateRaisCommandHandler : IRequestHandler<CreateRaisCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public CreateRaisCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(CreateRaisCommand request, CancellationToken cancellationToken)
        {
            var rais = new Rais()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Number = request.Number,
                Email = request.Email,
                MahallaKamitetId=request.MahallaKamitetId,
                RaisMale = request.RaisMale,

            };

            await _appDbConect.Raiss.AddAsync(rais);
            var result = await _appDbConect.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
