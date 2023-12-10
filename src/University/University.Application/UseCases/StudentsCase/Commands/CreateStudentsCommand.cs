using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.UseCases.StudentsCase.Dtos;

namespace University.Application.UseCases.StudentsCase.Commands
{
    public class CreateStudentsCommand : StudentDto, IRequest<bool>
    {
    }
}
