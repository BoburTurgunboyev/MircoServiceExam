using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Commands
{
    public class UpdateUser_BookCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public bool StatusActive { get; set; }
    }
}
