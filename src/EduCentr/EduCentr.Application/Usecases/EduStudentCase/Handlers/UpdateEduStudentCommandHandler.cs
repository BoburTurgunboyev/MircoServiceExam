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
    public class UpdateEduStudentCommandHandler : IRequestHandler<UpdateEduStudentCommand, bool>
    {
        private readonly IAppDbConnect _appDbConnect;

        public UpdateEduStudentCommandHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<bool> Handle(UpdateEduStudentCommand request, CancellationToken cancellationToken)
        {
            var res= await _appDbConnect.eduStudents.FirstOrDefaultAsync(x => x.Id == request.Id);
            if(res == null)
            {
                return false;
            }

            res.Firstname = request.Firstname;
            res.Lastname = request.Lastname;
            res.Age = request.Age;
            res.Phone = request.Phone;  
            res.Email = request.Email;

            _appDbConnect.eduStudents.Update(res);
            var rsult = await _appDbConnect.SaveChangesAsync(cancellationToken);
            return rsult > 0;

        }


        
    }
}
