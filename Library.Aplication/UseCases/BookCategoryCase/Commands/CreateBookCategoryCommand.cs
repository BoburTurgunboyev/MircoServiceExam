using Library.Aplication.UseCases.BookCategoryCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.BookCategoryCase.Commands
{
    public class CreateBookCategoryCommand : BookCategoryDto,IRequest<bool>
    {
    }
}
