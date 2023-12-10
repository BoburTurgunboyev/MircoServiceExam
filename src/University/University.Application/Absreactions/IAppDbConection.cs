using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Application.Absreactions
{
    public interface IAppDbConection
    {
        public DbSet<Students> studentss { get; set; }
        
        public DbSet<OverAllMarks> overAllMarkss { get; set; }
        public DbSet<ExamResults> examResultss { get; set; }
        public DbSet<Subjects> subjectss { get; set; }

        public ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
