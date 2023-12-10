using EduCentr.Application.Absreaction;
using EduCentr.Application.Usecases.CategoryCase.Commands;
using EduCentr.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.CategoryCase.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, bool>
    {
        private readonly IAppDbConnect _appDbConnect;

        public CreateCategoryCommandHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var strudents =  _appDbConnect.eduStudents.ToList();
            List<EduStudent> edustudents = new List<EduStudent>();

            foreach(var s in strudents)
            {
                if (request.EduStudents.Contains(s.Id))
                {
                    edustudents.Add(s);
                }
            }

            var category = new Category()
            {
                CategoryName = request.CategoryName,
                EduStudents = edustudents,
            };

            _appDbConnect.categories.Add(category);
            var res = await _appDbConnect.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
