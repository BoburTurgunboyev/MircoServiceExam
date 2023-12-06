using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OilaCase.Commands
{
    public class UpdateOilaCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int member { get; set; }
        public int MahallaKamitetId { get; set; }
    }
}
