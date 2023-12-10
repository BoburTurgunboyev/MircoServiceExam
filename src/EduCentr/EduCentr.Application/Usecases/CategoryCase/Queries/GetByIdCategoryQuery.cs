using EduCentr.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.CategoryCase.Queries
{
    public class GetByIdCategoryQuery : IRequest<Category>
    {
        public int Id { get; set; } 
    }
}
