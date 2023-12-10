using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.CategoryCase.Dtos
{
    public class CategoryDto
    {
        public string CategoryName { get; set; }
        public List<int> EduStudents { get; set; }
    }
}
