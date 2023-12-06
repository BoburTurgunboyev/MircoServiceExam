using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Enums;

namespace University.Domain.Entities
{
    public class ExamResults
    {
        public int Id { get; set; }
        public Term Terms { get; set; }
        public int ExemMark {  get; set; }
        public int Year {  get; set; }
        public int StudentSubjectId { get; set; }
        public StudentSubjects StudentSubject { get; set; }
    }
}
