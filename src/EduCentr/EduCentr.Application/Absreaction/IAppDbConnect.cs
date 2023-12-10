using EduCentr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Absreaction
{
    public interface IAppDbConnect
    {
        public DbSet<EduStudent> eduStudents { get; set; }
        public DbSet<Category> categories { get; set; } 

        public ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
