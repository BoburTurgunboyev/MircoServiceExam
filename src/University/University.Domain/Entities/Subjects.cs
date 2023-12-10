using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Domain.Entities
{
    public class Subjects
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }

        public ICollection<Students> StudentSubject { get; set; }
    }
}
