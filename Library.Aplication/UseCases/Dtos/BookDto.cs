using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Dtos
{
    public class BookDto
    {
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string PublishPlace { get; set; }
        public int BookCategoryId { get; set; }
    }
}
