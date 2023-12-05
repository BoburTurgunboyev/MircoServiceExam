using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Commands
{
    public class DeleteBookCategoryCommand : IRequest<bool>
    {
        public int Id { get; set; } 
    }
}
 