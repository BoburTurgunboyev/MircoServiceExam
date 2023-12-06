using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Domain.Entities
{
    public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public ICollection<StudentSubjects> StudentSubjects { get; set; }
        public ICollection<ExamResults> ExamResults { get; set; }
    }
}
