using Mahalla.Application.UseCases.OilaCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OilaCase.Commands
{
    public class CreateOilaCommand : OilaDto,IRequest<bool>
    {

    }
}
