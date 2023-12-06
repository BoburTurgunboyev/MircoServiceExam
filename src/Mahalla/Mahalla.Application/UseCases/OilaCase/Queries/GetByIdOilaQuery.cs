using Mahalla.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OilaCase.Queries
{
    public class GetByIdOilaQuery: IRequest<Oila>
    {
        public int Id { get; set; } 
    }
}
