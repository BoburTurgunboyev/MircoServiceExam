﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Application.UseCases.MahallaKamitetCase.Commands
{
    public class UpdateMahallaKomitetCommand :IRequest<bool>
    {
        public int Id { get; set; }
        public string MahallaName { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public int RaisId { get; set; }
    }
}
