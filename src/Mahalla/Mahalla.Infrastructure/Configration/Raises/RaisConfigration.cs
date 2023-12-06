using Mahalla.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Infrastructure.Configration.Raises
{
    public class RaisConfigration : IEntityTypeConfiguration<Rais>
    {
        public void Configure(EntityTypeBuilder<Rais> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.Age).IsRequired();
            entity.Property(e => e.Number).IsRequired();
            entity.Property(e => e.Email).IsRequired();



            entity.HasOne(e => e.MahallaKamitet)
                .WithOne(m => m.Rais)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
