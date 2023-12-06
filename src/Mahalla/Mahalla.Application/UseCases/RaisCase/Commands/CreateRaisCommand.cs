using Mahalla.Application.UseCases.RaisCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.RaisCase.Commands
{
    public class CreateRaisCommand : RaisDto,IRequest<bool>
    {
    }
}
