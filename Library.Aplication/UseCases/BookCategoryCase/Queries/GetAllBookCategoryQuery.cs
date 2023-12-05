﻿using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Queries
{
    public class GetAllBookCategoryQuery:IRequest<List<BookCategory>>
    {
    }
}
