using Mahalla.Domain.Enumes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OdamCase.Commands
{
    public class UpdateOdamCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public int HomeNumber { get; set; }
        public int Age { get; set; }
        public string Number { get; set; }
        public Male OdamMale { get; set; }
        public int OilaId { get; set; }
    }
}
