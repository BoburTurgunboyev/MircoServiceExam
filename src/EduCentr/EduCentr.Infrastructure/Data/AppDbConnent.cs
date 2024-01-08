using EduCentr.Application.Absreaction;
using EduCentr.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduCentr.Infrastructure.Data
{
    public class AppDbConnent : DbContext, IAppDbConnect
    {
        public AppDbConnent(DbContextOptions<AppDbConnent> options) : base(options)
        {
            
        }

        public DbSet<EduStudent> eduStudents { get; set; }
        public DbSet<Category> categories { get; set; }

        async ValueTask<int> IAppDbConnect.SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
            
 
            
        }
    }
}
