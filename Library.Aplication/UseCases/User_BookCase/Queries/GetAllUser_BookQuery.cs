using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Queries
{
    public class GetAllUser_BookQuery:IRequest<List<User_Book>>
    {
    }
}
