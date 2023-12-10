using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.SubjectsCase.Queries;
using University.Domain.Entities;

namespace University.Application.UseCases.SubjectsCase.Handlers
{
    public class GetByIdSubjectsQueryHandler : IRequestHandler<GetByIdSubjectsQuery, Subjects>
    {
        private readonly IAppDbConection _appDbConection;

        public GetByIdSubjectsQueryHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<Subjects> Handle(GetByIdSubjectsQuery request, CancellationToken cancellationToken)
        {
            var result =  await _appDbConection.subjectss.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
