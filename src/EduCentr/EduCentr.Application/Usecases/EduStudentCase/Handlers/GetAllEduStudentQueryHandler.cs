using EduCentr.Application.Absreaction;
using EduCentr.Application.Usecases.EduStudentCase.Queries;
using EduCentr.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.EduStudentCase.Handlers
{
    public class GetAllEduStudentQueryHandler : IRequestHandler<GetAllEduStudentQuery, List<EduStudent>>
    {
        private readonly IAppDbConnect _appDbConnect;

        public GetAllEduStudentQueryHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<List<EduStudent>> Handle(GetAllEduStudentQuery request, CancellationToken cancellationToken)
        {
            var result  = await _appDbConnect.eduStudents.ToListAsync(cancellationToken);
            return result;
        }
    }
}
