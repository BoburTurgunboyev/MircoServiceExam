using EduCentr.Application.Absreaction;
using EduCentr.Application.Usecases.EduStudentCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.EduStudentCase.Handlers
{
    public class DeleteEduEduStudentCommandHandler : IRequestHandler<DeleteEduEduStudentCommand, bool>
    {
        private readonly IAppDbConnect _appDbConnect;

        public DeleteEduEduStudentCommandHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<bool> Handle(DeleteEduEduStudentCommand request, CancellationToken cancellationToken)
        {
            var res= await _appDbConnect.eduStudents.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }
            _appDbConnect.eduStudents.Remove(res);
            var result = await _appDbConnect.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
