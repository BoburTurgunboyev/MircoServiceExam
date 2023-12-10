using Mahalla.Application.Absreactions;
using Mahalla.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Infrastructure.Data
{
    public class AppBbContect : DbContext, IAppDbConect
    {

        public AppBbContect(DbContextOptions<AppBbContect> options):base (options)
        {
            Database.Migrate();
        }   

        public DbSet<MahallaKamitet> MahallaKamitets { get; set; }
        public DbSet<Rais> Raiss {  get; set; }
        public DbSet<Oila> Oilas {  get; set; }
        public DbSet<Odam> Odams {  get; set; }
    }
}
