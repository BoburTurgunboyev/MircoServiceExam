using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.StudentsCase.Commands;
using University.Domain.Entities;

namespace University.Application.UseCases.StudentsCase.Handler
{
    public class CreateStudentsCommandHandler : IRequestHandler<CreateStudentsCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public CreateStudentsCommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(CreateStudentsCommand request, CancellationToken cancellationToken)
        {

            var strudents = _appDbConection.subjectss.ToList();
            List<Subjects> edustudents = new List<Subjects>();

            foreach (var s in strudents)
            {
                if (request.Studentsss.Contains(s.Id))
                {
                    edustudents.Add(s);
                }
            }

            var student = new Students()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                StudentSubjects = edustudents
               
            };

            _appDbConection.studentss.Add(student);
            var res = await _appDbConection.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
