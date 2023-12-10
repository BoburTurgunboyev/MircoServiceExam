using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Application.UseCases.StudentsCase.Dtos
{
    public class StudentDto
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public  List<int> Studentsss { get; set; }
    }
}
