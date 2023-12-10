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
    public class GetByIdStudentsQueryHandler : IRequestHandler<GetByIdStudentsQuery, Students>
    {
        private readonly IAppDbConection _appDbConection;

        public GetByIdStudentsQueryHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<Students> Handle(GetByIdStudentsQuery request, CancellationToken cancellationToken)
        {
           var res = await _appDbConection.studentss.FirstOrDefaultAsync(x => x.Id == request.Id);
            return res;
        }
    }
}
