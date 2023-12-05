using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Queries
{
    public class GetByIdUser_BookQuery:IRequest<User_Book>
    {
        public int Id { get; set; }
    }
}
