using Library.Aplication.UseCases.User_BookCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Commands
{
    public class CreateUser_BookCommand:User_BookDto,IRequest<bool>
    {
    }
}
