using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.User_BookCase.Dtos
{
    public class User_BookDto
    {
        public bool StatusActive { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
    }
}
