using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCase.Queries
{
    public class GetByIdBookQuery : IRequest<Book>
    {
        public int Id { get; set; } 
    }
}
