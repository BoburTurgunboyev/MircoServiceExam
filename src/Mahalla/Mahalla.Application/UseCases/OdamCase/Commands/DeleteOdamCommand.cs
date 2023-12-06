using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OdamCase.Commands
{
    public class DeleteOdamCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
