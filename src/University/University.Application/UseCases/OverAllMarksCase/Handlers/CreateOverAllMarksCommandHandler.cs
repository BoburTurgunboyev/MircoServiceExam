using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Application.UseCases.OverAllMarksCase.Commands;
using University.Domain.Entities;

namespace University.Application.UseCases.OverAllMarksCase.Handlers
{
    public class CreateOverAllMarksCommandHandlerv : IRequestHandler<CreateOverAllMarksCommand, bool>
    {
        private readonly IAppDbConection _appDbConection;

        public CreateOverAllMarksCommandHandlerv(IAppDbConection appDbConection)
        {
            _appDbConection = appDbConection;
        }

        public async Task<bool> Handle(CreateOverAllMarksCommand request, CancellationToken cancellationToken)
        {
            var OverAllMarks = new OverAllMarks()
            {
                MarkType =request.MarkType,
                StudentsId = request.StudentsId,

            };

            _appDbConection.overAllMarkss.Add(OverAllMarks);
            var result = await _appDbConection.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
