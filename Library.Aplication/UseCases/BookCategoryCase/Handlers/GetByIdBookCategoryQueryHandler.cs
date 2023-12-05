﻿using Library.Aplication.Absreactions;
using Library.Aplication.UseCases.BookCategoryCase.Queries;
using Library.Aplication.UseCases.UserCase.Queries;
using Library.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Handlers
{
    public class GetByIdBookCategoryQueryHandler : IRequestHandler<GetByIdBookCategoryQuery, BookCategory>
    {
        private readonly IAppDbContext _appDbContext;

        public GetByIdBookCategoryQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<BookCategory> Handle(GetByIdBookCategoryQuery request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.BookCategories.FirstOrDefaultAsync(x => x.Id == request.Id);
            return res;
        }
    }
}
