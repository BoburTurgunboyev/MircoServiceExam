using Library.Aplication.UseCases.UserCases.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Library.Aplication.UseCases.UserCases.Commands
{
    public class CreateBookCommand : BookDto, IRequest<bool>
    {
    }
}
