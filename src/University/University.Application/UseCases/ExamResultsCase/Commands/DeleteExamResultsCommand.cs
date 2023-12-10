using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.UseCases.ExamResultsCase.Commands
{
    public class DeleteExamResultsCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
