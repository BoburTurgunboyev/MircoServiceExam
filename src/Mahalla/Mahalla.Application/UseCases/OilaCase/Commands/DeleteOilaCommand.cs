using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OilaCase.Commands
{
    public class DeleteOilaCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
