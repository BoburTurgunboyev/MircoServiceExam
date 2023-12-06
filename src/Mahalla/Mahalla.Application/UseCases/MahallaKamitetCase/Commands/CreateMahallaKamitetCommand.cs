using Mahalla.Application.UseCases.MahallaKamitetCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.MahallaKamitetCase.Commands
{
    public class CreateMahallaKamitetCommand :MahallaKamitetDto, IRequest<bool>
    {
    }
}
