﻿using Mahalla.Application.UseCases.OdamCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.OdamCase.Commands
{
    public class CreateOdamCommand : OdamDto,IRequest<bool>
    {
    }
}
