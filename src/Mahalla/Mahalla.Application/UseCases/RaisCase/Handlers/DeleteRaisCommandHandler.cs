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
    public class DeleteRaisCommandHandler : IRequestHandler<DeleteRaisCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public DeleteRaisCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(DeleteRaisCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.Raiss.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            _appDbConect.Raiss.Remove(res);
            var result = await _appDbConect.SaveChangesAsync(cancellationToken);
            return result>0;
        }
    }
}
