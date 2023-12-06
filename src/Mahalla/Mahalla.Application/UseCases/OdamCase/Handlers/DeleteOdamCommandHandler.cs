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
    public class DeleteOdamCommandHandler : IRequestHandler<DeleteOdamCommand, bool>
    {
        private readonly IAppDbConect _appDbConect;

        public DeleteOdamCommandHandler(IAppDbConect appDbConect)
        {
            _appDbConect = appDbConect;
        }

        public async Task<bool> Handle(DeleteOdamCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConect.Odams.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (res == null)
            {
                return false;
            }

            _appDbConect.Odams.Remove(res);
            var result = await _appDbConect.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
