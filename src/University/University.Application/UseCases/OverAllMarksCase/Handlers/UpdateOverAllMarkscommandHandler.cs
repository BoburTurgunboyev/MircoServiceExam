using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.OverAllMarksCase.Commands;
using University.Application.UseCases.OverAllMarksCase.Dtos;
using University.Domain.Entities;

namespace University.Application.UseCases.OverAllMarksCase.Handlers
{
    public class UpdateOverAllMarkscommandHandler : IRequestHandler<UpdateOverAllMarksCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public UpdateOverAllMarkscommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(UpdateOverAllMarksCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConection.overAllMarkss.FirstOrDefaultAsync(x =>  x.Id == request.Id);
            if (res == null)
            {
                return false;
            }

            res.MarkType = request.MarkType;
            res.StudentsId = request.StudentsId;

            _appDbConection.overAllMarkss.Update(res);
            var result = await _appDbConection.SaveChangesAsync(cancellationToken);
            return result > 0;

            
        }
    }
}
