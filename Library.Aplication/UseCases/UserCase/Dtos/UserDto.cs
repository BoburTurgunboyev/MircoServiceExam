using Library.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.UserCases.Dtos
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserAdress { get; set; }
        public string Email { get; set; }
        public string? ImageUrl { get; set; }
        public string UserPhone { get; set; }
        public Role UserRole { get; set; }
    }
}
