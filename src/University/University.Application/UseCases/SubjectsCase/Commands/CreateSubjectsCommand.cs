using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.UseCases.StudentsCase.Dtos;
using University.Application.UseCases.SubjectsCase.Dtos;

namespace University.Application.UseCases.SubjectsCase.Commands
{
    public class CreateSubjectsCommand :SubjectsDto, IRequest<bool>
    {
    }
}
