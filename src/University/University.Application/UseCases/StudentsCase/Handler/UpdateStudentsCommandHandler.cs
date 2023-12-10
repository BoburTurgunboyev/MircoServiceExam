using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.StudentsCase.Commands;

namespace University.Application.UseCases.StudentsCase.Handler
{
    public class UpdateStudentsCommandHandler : IRequestHandler<UpdateStudentsCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public UpdateStudentsCommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(UpdateStudentsCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConection.studentss.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }

            res.FirstName = request.FirstName;
            res.LastName = request.LastName;

            _appDbConection.studentss.Update(res);
            var result = await _appDbConection.SaveChangesAsync(cancellationToken);
            return result > 0;
            
        }
    }
}
