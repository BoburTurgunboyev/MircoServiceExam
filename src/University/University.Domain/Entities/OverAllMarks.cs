using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Enums;

namespace University.Domain.Entities
{
    public class OverAllMarks
    {
        public int Id {  get; set; }
        public MarkType MarkType { get; set; }

        public int StudentsId { get; set; }

        public Students Students { get; set; }
    }
}
