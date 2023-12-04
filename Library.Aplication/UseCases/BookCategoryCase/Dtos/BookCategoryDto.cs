using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Dtos
{
    public class BookCategoryDto
    {
        public string CategoryName { get; set; }
        public string Block { get; set; }
        public int? LibraryId { get; set; }

    }
}
