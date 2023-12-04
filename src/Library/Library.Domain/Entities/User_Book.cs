using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class User_Book
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Book))]
        public int BookId {  get; set; }
        public Book Book { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        public bool StatusActive { get; set; }
    }
}
