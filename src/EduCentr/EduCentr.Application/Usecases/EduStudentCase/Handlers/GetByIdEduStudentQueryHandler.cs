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
    public class GetByIdEduStudentQueryHandler : IRequestHandler<GetByIdEduStudentQuery, EduStudent>
    {
        private readonly IAppDbConnect _appDbConnect;

        public GetByIdEduStudentQueryHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<EduStudent> Handle(GetByIdEduStudentQuery request, CancellationToken cancellationToken)
        {
            var res= await _appDbConnect.eduStudents.FirstOrDefaultAsync(x => x.Id == request.Id);
            return res;
        }
    }
}
