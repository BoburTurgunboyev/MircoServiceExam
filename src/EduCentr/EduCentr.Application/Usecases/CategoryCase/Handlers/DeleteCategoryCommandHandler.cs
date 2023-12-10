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
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly IAppDbConnect _appDbConnect;

        public DeleteCategoryCommandHandler(IAppDbConnect appDbConnect)
        {
            _appDbConnect = appDbConnect;
        }

        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
           var result = await _appDbConnect.categories.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }

            _appDbConnect.categories.Remove(result);
            var re = await _appDbConnect.SaveChangesAsync(cancellationToken);
            return re>0;
        }
    }
}
