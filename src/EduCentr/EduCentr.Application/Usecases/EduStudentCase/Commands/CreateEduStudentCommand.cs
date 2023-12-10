﻿using EduCentr.Application.Usecases.EduStudentCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCentr.Application.Usecases.EduStudentCase.Commands
{
    public class CreateEduStudentCommand :EduStudentDto, IRequest<bool>
    {
    }
}
