using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.ExamResultsCase.Commands;
using University.Domain.Entities;

namespace University.Application.UseCases.ExamResultsCase.Handlers
{
    public class UpdateExemResultsCommandHandler : IRequestHandler<UpdateExemResultsCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public UpdateExemResultsCommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(UpdateExemResultsCommand request, CancellationToken cancellationToken)
        {
            var res =await _appDbConection.examResultss.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }

            var exem = new ExamResults()
            {

                ExemMark = request.ExemMark,
                Terms = request.Terms,
                Year = request.Year,
               

            };

            _appDbConection.examResultss.Update(exem);
            var result = await _appDbConection.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
