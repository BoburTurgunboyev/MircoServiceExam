using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Configurations.Librariess
{
    public class LibraryConfiguration : IEntityTypeConfiguration<Domain.Entities.Library>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Library> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.BookCategories)
                .WithOne(x => x.Library)
                .HasForeignKey(x => x.LibraryId)
                .OnDelete(DeleteBehavior.Cascade);
                

        }
    }
}
