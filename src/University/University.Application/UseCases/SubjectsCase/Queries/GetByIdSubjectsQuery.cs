using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Application.UseCases.SubjectsCase.Queries
{
    public class GetByIdSubjectsQuery : IRequest<Subjects>
    {
        public int Id { get; set; }
    }
}
