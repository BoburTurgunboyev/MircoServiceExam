using Mahalla.Application.Absreactions;
using Mahalla.Application.UseCases.OilaCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OilaCase.Handlers
{
    public class DeleteOilaCommandHandler : IRequestHandler<DeleteOilaCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public DeleteOilaCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(DeleteOilaCommand request, CancellationToken cancellationToken)
        {
            var res =await _appDbConect.Oilas.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            _appDbConect.Oilas.Remove(res);
            var result = await _appDbConect.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
