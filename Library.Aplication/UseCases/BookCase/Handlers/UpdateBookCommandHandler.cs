using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.BookCase.Commands;
using Library.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCase.Handlers
{
    public class UpdateBookCommandHandler:IRequestHandler<UpdateBookCommand,bool>
    {
        private readonly IAppDbContext _appDbContext;

        public UpdateBookCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Books.FirstOrDefaultAsync(x =>x.Id == request.Id); 
            if (result == null)
            {
                return false;
            }

            result.Id = request.Id;
            result.Title = request.Title;
            result.DatePublished = DateTime.Now;
            result.PublishPlace = request.PublishPlace;
            result.BookCategoryId = request.BookCategoryId;
            

             _appDbContext.Books.Update(result);
            var res = await _appDbContext.SaveChangesAsync(cancellationToken);
            return res>0;
        }
    }
}
