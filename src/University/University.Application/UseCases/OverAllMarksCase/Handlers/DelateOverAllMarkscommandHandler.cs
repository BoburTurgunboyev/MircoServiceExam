using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.OverAllMarksCase.Commands;

namespace University.Application.UseCases.OverAllMarksCase.Handlers
{
    public class DelateOverAllMarkscommandHandler : IRequestHandler<DeleteOverAllMarkscommand, bool>

    {
        private readonly IAppDbConection _appDbConection;

        public DelateOverAllMarkscommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(DeleteOverAllMarkscommand request, CancellationToken cancellationToken)
        {
            var reult = await _appDbConection.overAllMarkss.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (reult == null)
            {
                return false;
            }
            _appDbConection.overAllMarkss.Remove(reult);
            var result= await _appDbConection.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
