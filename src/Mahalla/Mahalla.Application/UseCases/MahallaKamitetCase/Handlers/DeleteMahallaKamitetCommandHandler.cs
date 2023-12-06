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
    public class DeleteMahallaKamitetCommandHandler : IRequestHandler<DeleteMahallaKamitetCommand,bool>
    {
        private readonly IAppDbConect _appDbConect;

        public DeleteMahallaKamitetCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(DeleteMahallaKamitetCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.MahallaKamitets.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (res == null) 
            {
                return false;
            }

            _appDbConect.MahallaKamitets.Remove(res);
            var result = await _appDbConect.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
