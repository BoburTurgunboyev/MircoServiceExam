using Library.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.UserCase.Commands
{
    public class UpdateUserCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? UserName { get; set; }
        public int UserAge { get; set; }
        public string UserAdress { get; set; }
        public string Email { get; set; }
        public string UserPhone { get; set; }
        public Role UserRole { get; set; }
    }
}
