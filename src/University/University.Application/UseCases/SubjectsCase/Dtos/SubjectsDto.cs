using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Application.UseCases.SubjectsCase.Dtos
{
    public class SubjectsDto
    {
        public string SubjectName { get; set; }
        public List<int> Subjects { get; set; }
    }
}
