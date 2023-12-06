using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.OilaCase.Commands;
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
    public class UpdateOilaCommandHandler : IRequestHandler<UpdateOilaCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public UpdateOilaCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(UpdateOilaCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.Oilas.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }

          
            res.member = request.member;
            res.MahallaKamitetId =request.MahallaKamitetId;

            _appDbConect.Oilas.Update(res);
            var result = await _appDbConect.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
