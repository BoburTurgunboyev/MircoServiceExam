using Library.Aplication.UseCases.UserCases.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.UserCases.Commands
{
    public class CreateUserCommand:UserDto,IRequest<bool>
    {
    }
}
