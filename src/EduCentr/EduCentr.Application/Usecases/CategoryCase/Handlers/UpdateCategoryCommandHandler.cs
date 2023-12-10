using EduCentr.Application.Absreaction;
using EduCentr.Application.Usecases.CategoryCase.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.CategoryCase.Handlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, bool>
    {
        private readonly IAppDbConnect _appDbConnect;

        public UpdateCategoryCommandHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var res =await _appDbConnect.categories.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (res == null)
            {
                return false;
            }

            res.CategoryName = request.CategoryName;
            

            _appDbConnect.categories.Update(res);
            var result =await _appDbConnect.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
        

       
    }
}
