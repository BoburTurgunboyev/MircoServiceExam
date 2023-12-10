using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.SubjectsCase.Commands;

namespace University.Application.UseCases.SubjectsCase.Handlers
{
    public class DeleteSubjectsCommandHandler : IRequestHandler<DeleteSubjectsCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public DeleteSubjectsCommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(DeleteSubjectsCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConection.subjectss.FirstOrDefaultAsync(x =>x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            _appDbConection.subjectss.Remove(res);
            var result =await _appDbConection.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
