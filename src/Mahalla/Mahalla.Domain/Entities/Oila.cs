using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Domain.Entities
{
    public class Oila
    {
        public int Id { get; set; }
        public int member {  get; set; }


        [ForeignKey(nameof(MahallaKamitet))]
        public int MahallaKamitetId { get; set; }
        public MahallaKamitet MahallaKamitet { get; set; }

        public ICollection<Odam> Odams { get; set; }
    }
}
