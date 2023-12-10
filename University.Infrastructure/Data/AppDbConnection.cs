
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Absreactions;
using University.Domain.Entities;

namespace University.Infrastructure.Data
{
    public class AppDbConnection : DbContext, IAppDbConection
    {
        public AppDbConnection(DbContextOptions<AppDbConnection> options):base(options) 
        {
            Database.Migrate();
        }

        public DbSet<Students> studentss { get; set; }
       
        public DbSet<OverAllMarks> overAllMarkss { get; set; }   
        public DbSet<ExamResults> examResultss { get; set; } 
        public DbSet<Subjects> subjectss { get; set; }

        async ValueTask<int> IAppDbConection.SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
