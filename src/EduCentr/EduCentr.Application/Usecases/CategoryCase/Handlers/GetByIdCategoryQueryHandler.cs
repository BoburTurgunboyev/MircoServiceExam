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
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQuery, Category>
    {
        private readonly IAppDbConnect _appDbConnect;

        public GetByIdCategoryQueryHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<Category> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
        {
            var result = await _appDbConnect.categories.FirstOrDefaultAsync(x => x.Id == request.Id);
            return result;
        }
    }
}
