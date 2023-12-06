using Mahalla.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mahalla.Application.UseCases.OdamCase.Queries
{
    public class GetByIdOdamQuery : IRequest<Odam>
    {
        public int Id { get; set; }
    }
}
