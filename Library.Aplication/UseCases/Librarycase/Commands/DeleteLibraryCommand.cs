using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.UseCases.Librarycase.Commands
{
    public class DeleteLibraryCommand :IRequest<bool>
    {
        public int Id { get; set; } 
    }
}
