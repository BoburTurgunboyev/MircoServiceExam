using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Queries
{
    public class GetByIdLibraryQuery : IRequest<Domain.Entities.Library>
    {
        public int Id { get; set; } 
    }
}
