using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Configurations.User_Bookss
{
    public class User_BookConfiguration : IEntityTypeConfiguration<User_Book>
    {
        public void Configure(EntityTypeBuilder<User_Book> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
               .WithMany(x => x.User_Books)
               .HasForeignKey(x => x.UserId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
