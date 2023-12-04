using Library.Aplication.UseCases.Librarycase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Commands
{
    public class CreateLibraryCommand :LibraryDto, IRequest<bool>
    {
    }
}
