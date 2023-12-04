using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.UserCases.Commands;
using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.UserCases.Handler
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, bool>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateBookCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book()
            {
                PublishPlace = request.PublishPlace,
                Title = request.Title,
                DatePublished = request.DatePublished,
                BookCategoryId = request.BookCategoryId,
            };

            await _appDbContext.Books.AddAsync(book);
            var result = await _appDbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
