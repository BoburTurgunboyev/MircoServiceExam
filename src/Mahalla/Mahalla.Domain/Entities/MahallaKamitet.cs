using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Domain.Entities
{
    public class MahallaKamitet
    {
        public int Id { get; set; } 
        public string MahallaName { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }

        public int RaisId { get; set; }
        public Rais Rais { get; set; }

        public ICollection<Oila> Oilas { get; set; }
        
    }
}
