using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Enums;

namespace University.Application.UseCases.OverAllMarksCase.Dtos
{
    public class OverAllMarksDto
    {
    
        public MarkType MarkType { get; set; }

        public int StudentsId { get; set; }
    }
}
