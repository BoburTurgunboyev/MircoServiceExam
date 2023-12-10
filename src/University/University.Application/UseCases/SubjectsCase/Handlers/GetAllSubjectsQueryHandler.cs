using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.SubjectsCase.Queries;
using University.Domain.Entities;

namespace University.Application.UseCases.SubjectsCase.Handlers
{
    public class GetAllSubjectsQueryHandler : IRequestHandler<GetAllSubjectsQuery, List<Subjects>>
    {
        private readonly IAppDbConection _appDbConection;

        public GetAllSubjectsQueryHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<List<Subjects>> Handle(GetAllSubjectsQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbConection.subjectss.ToListAsync(cancellationToken);
            return result;
        }
    }
}
