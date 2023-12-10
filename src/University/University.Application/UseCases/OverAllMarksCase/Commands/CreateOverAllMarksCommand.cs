using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.UseCases.OverAllMarksCase.Dtos;

namespace University.Application.UseCases.OverAllMarksCase.Commands
{
    public class CreateOverAllMarksCommand : OverAllMarksDto, IRequest<bool>
    {
    }
}
