using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.ExamResultsCase.Commands;

namespace University.Application.UseCases.ExamResultsCase.Handlers
{
    public class DeleteExamResultsCommandHandler : IRequestHandler<DeleteExamResultsCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public DeleteExamResultsCommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(DeleteExamResultsCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbConection.examResultss.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            _appDbConection.examResultss.Remove(res);
            var result = await _appDbConection.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
