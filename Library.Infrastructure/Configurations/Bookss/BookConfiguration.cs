using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Configurations.Bookss
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.BookCategory)
                .WithMany(x => x.Books)
                .HasForeignKey(x =>x.BookCategory.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x =>x.User_Books)
                .WithOne(x => x.Book)
                .HasForeignKey(x =>x.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            
        }
    }
}
