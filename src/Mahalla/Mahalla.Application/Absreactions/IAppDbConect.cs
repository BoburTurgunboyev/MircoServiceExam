using Mahalla.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.Absreactions
{
    public interface IAppDbConect
    {
        public DbSet<MahallaKamitet> MahallaKamitets { get; set; }
        public DbSet<Rais> Raiss { get; set; }
        public DbSet<Oila> Oilas { get; set; }  
        public DbSet <Odam> Odams { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
