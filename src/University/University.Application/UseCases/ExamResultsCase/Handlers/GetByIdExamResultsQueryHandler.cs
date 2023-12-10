using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.ExamResultsCase.Queries;
using University.Domain.Entities;

namespace University.Application.UseCases.ExamResultsCase.Handlers
{
    public class GetByIdExamResultsQueryHandler : IRequestHandler<GetByIdExamResultsQuery, ExamResults>
    {
        private readonly IAppDbConection _appDbConection;

        public GetByIdExamResultsQueryHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<ExamResults> Handle(GetByIdExamResultsQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbConection.examResultss.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
