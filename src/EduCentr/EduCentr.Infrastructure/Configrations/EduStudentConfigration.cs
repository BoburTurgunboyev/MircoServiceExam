using EduCentr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Infrastructure.Configrations
{
    public class EduStudentConfigration : IEntityTypeConfiguration<EduStudent>
    {
        public void Configure(EntityTypeBuilder<EduStudent> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Firstname).IsRequired();
            entity.Property(e => e.Lastname).IsRequired();
            entity.Property(e => e.Age).IsRequired();
            entity.Property(e => e.Phone).IsRequired();
            entity.Property(e => e.Email).IsRequired();

            entity.HasMany(e => e.Categories)
                .WithMany(c => c.EduStudents)
                .UsingEntity(nameof(CategoryEduStudent));
                
                
        }
    }
}
