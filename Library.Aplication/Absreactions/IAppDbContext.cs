using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Library.Aplication.Absreactions
{
    public  interface IAppDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Book> Users_Books { get; set; }
        public DbSet<Domain.Entities.Library> Libraries { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }


        public ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
