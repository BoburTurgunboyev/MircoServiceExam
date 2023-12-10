using MediatR;
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
    public class CreateExamResultsCommandHandler : IRequestHandler<CreateExamResultsCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public CreateExamResultsCommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(CreateExamResultsCommand request, CancellationToken cancellationToken)
        {
            var exam = new ExamResults()
            {
                Terms = request.Terms,
                ExemMark = request.ExemMark,
                Year = request.Year,
                
            };

            await _appDbConection.examResultss.AddAsync(exam);
            var res = await _appDbConection.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
