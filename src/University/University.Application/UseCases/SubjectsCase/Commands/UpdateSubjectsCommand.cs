using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.UseCases.SubjectsCase.Dtos;

namespace University.Application.UseCases.SubjectsCase.Commands
{
    public class UpdateSubjectsCommand : SubjectsDto, IRequest<bool>
    {
        public int Id {  get; set; }
    }
}
