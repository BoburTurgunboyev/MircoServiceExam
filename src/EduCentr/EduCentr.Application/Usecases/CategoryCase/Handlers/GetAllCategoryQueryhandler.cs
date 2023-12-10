using EduCentr.Application.Absreaction;
using EduCentr.Application.Usecases.CategoryCase.Queries;
using EduCentr.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.CategoryCase.Handlers
{
    public class GetAllCategoryQueryhandler : IRequestHandler<GetAllCategoryQuery, List<Category>>
    {
        private readonly IAppDbConnect _appDbConnect;

        public GetAllCategoryQueryhandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<List<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
           var result = await _appDbConnect.categories.ToListAsync(cancellationToken);
            return result;
        }
    }
}
