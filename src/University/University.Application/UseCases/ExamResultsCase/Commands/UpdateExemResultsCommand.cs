using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.UseCases.ExamResultsCase.Dtos;

namespace University.Application.UseCases.ExamResultsCase.Commands
{
    public class UpdateExemResultsCommand :ExemResultsDto, IRequest<bool>
    {
        public int Id { get; set; }
    }
}
