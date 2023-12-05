using Library.Aplication.UseCases.UserCases.Dtos;
using Library.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.UserCase.Commands
{
    public class UpdateUserCommand:UserDto,IRequest<bool>
    {
        public int Id { get; set; }
    }
}
