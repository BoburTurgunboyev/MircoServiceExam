using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Application.UseCases.OverAllMarksCase.Queries
{
    public class GetByIdOverAllMarksQuery:IRequest<OverAllMarks>
    {
        public int Id {  get; set; }
    }
}
