using Mahalla.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mahalla.Infrastructure.Configration.Odams
{
    public class OdamConfigration : IEntityTypeConfiguration<Odam>
    {
        public void Configure(EntityTypeBuilder<Odam> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.StreetName).IsRequired();
            entity.Property(e => e.HomeNumber).IsRequired();
            entity.Property(e => e.Age).IsRequired();
            entity.Property(e => e.Number).IsRequired();

            entity.HasOne(e => e.Oila)
            .WithMany(o => o.Odams)
            .HasForeignKey(e => e.OilaId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
