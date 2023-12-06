using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Domain.Entities
{
    public class StudentSubjects
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Students Students { get; set; }

        public int SubjectsId { get; set; }
        public Subjects Subjects { get; set; }

        public ICollection<ExamResults> ExamResults { get; set; }

    }
}
