using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.SubjectsCase.Commands;
using University.Domain.Entities;

namespace University.Application.UseCases.SubjectsCase.Handlers
{
    public class CreateSubjectsCommandHandler : IRequestHandler<CreateSubjectsCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public CreateSubjectsCommandHandler(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(CreateSubjectsCommand request, CancellationToken cancellationToken)
        {

            var strudents = _appDbConection.studentss.ToList();
            List<Students> edustudents = new List<Students>();

            foreach (var s in strudents)
            {
                if (request.Subjects.Contains(s.Id))
                {
                    edustudents.Add(s); 
                }
            }
            var subject = new Subjects()
            {
                SubjectName = request.SubjectName,
                StudentSubject= edustudents
                
                
            };
            _appDbConection.subjectss.Add(subject);
            var res = await _appDbConection.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
