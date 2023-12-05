using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Commands
{
    public class UpdateBookCategoryCommand : IRequest<bool>
    {
        public int Id { get; set; } 
        public string CategoryName { get; set; }
        public string Block { get; set; }
        public int? LibraryId { get; set; }

    }
}
