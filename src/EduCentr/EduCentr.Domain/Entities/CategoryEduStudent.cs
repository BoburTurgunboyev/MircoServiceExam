using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Domain.Entities
{
    public  class CategoryEduStudent
    {
        public int CatecoryId { get; set; } 
        public Category Category { get; set; }

        public int EduStudentId {  get; set; }  
        public EduStudent EduStudent { get; set; }
    }
}
