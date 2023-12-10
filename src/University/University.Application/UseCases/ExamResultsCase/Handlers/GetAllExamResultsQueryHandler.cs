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
    public class GetAllExamResultsQueryHandler : IRequestHandler<GetAllExamResultsQuery, List<ExamResults>>
    {
        private readonly IAppDbConection _appDbConection;

        public GetAllExamResultsQueryHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<List<ExamResults>> Handle(GetAllExamResultsQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbConection.examResultss.ToListAsync(cancellationToken);
            return result;
        }
    }
}
