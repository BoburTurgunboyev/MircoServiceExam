using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Enums;

namespace University.Application.UseCases.ExamResultsCase.Dtos
{
    public class ExemResultsDto
    {
        
        public Term Terms { get; set; }
        public int ExemMark { get; set; }
        public int Year { get; set; }
        public int StudentSubjectId { get; set; }
    }
}
