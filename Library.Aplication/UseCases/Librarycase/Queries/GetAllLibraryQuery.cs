using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Queries
{
    public class GetAllLibraryQuery  : IRequest<List<Domain.Entities.Library>>
    {
    }
}
