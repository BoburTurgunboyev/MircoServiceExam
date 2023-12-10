using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Domain.Entities
{
    public class EduStudent
    {
        public int Id { get; set; }
        public string Firstname {  get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
