using EduCentr.Application.Absreaction;
using EduCentr.Application.Usecases.EduStudentCase.Commands;
using EduCentr.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.EduStudentCase.Handlers
{
    public class CreateEduStudentCommandHandler : IRequestHandler<CreateEduStudentCommand, bool>
    {
        private readonly IAppDbConnect _appDbConnect;

        public CreateEduStudentCommandHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<bool> Handle(CreateEduStudentCommand request, CancellationToken cancellationToken)
        {

            var strudents = _appDbConnect.categories.ToList();
            List<Category> edustudents = new List<Category>();

            foreach (var s in strudents)
            {
                if (request.Categories.Contains(s.Id))
                {
                    edustudents.Add(s);
                }
            }
            var Student = new EduStudent()
            {
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Age = request.Age,
                Phone = request.Phone,
                Email = request.Email,
                Categories = edustudents
            };

            _appDbConnect.eduStudents.Add(Student); 

            var result = await _appDbConnect.SaveChangesAsync(cancellationToken);
            return result > 0;
                
        }
    }
}
