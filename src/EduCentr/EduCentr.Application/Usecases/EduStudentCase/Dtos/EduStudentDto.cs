using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.EduStudentCase.Dtos
{
    public class EduStudentDto
    {
       
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public List<int>  Categories { get; set; }
    }
}
