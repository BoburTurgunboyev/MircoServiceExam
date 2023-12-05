.using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string PublishPlace { get; set; }

        [ForeignKey(nameof(BookCategory))]
        public int BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }  

        public ICollection<User_Book> User_Books { get; set; }



    }
}
