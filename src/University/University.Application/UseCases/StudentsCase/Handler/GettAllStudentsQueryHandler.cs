using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.StudentsCase.Queries;
using University.Domain.Entities;

namespace University.Application.UseCases.StudentsCase.Handler
{
    public class GettAllStudentsQueryHandler : IRequestHandler<GettAllStudentsQuery, List<Students>>
    {
        private readonly IAppDbConection _appDbConection;

        public GettAllStudentsQueryHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<List<Students>> Handle(GettAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var res =await _appDbConection.studentss.ToListAsync(cancellationToken);
            return res;
        }
    }
}
