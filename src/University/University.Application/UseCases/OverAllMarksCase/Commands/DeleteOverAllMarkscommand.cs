﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.UseCases.OverAllMarksCase.Commands
{
    public class DeleteOverAllMarkscommand : IRequest<bool>
    {
        public int Id {  get; set; }
    }
}
