using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class BookCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Block { get; set; }


        [ForeignKey(nameof(Library))]
        public int? LibraryId { get; set; }
        public Library? Library { get; set; }

        public ICollection<Book> Books { get; set;}
      
    }
}

