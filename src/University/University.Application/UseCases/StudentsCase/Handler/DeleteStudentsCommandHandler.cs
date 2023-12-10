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
    public class DeleteStudentsCommandHandler : IRequestHandler<DeleteStudentsCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public DeleteStudentsCommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(DeleteStudentsCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConection.studentss.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            _appDbConection.studentss.Remove(res);
            var result = await _appDbConection.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
