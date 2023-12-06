using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.UseCases.StudentsCase.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
    }
}
