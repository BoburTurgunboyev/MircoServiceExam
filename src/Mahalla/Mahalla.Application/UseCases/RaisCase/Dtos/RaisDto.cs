using Mahalla.Domain.Enumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.RaisCase.Dtos
{
    public class RaisDto
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public Male RaisMale { get; set; }
        public int MahallaKamitetId { get; set; }
    }
}
