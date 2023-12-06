using Mahalla.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Infrastructure.Configration.Oillas
{
    public class OilaConfigration : IEntityTypeConfiguration<Oila>
    {
        public void Configure(EntityTypeBuilder<Oila> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.member).IsRequired();

            entity.HasOne(e => e.MahallaKamitet)
                .WithMany(m => m.Oilas)
                .HasForeignKey(e => e.MahallaKamitetId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
