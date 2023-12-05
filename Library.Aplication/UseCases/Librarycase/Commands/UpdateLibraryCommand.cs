using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Commands
{
    public class UpdateLibraryCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string LibraryName { get; set; }
        public string LibraryNumber { get; set; }
        public string Location { get; set; }
    }
}
