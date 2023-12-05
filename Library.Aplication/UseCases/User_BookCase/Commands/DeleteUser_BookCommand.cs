using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Commands
{
    public class DeleteUser_BookCommand : IRequest<bool>
    {
        public int Id { get; set; } 
    }
}
