using EduCentr.Application.Usecases.CategoryCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.CategoryCase.Commands
{
    public  class CreateCategoryCommand :CategoryDto, IRequest<bool>
    {
    }
}
