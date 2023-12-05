using Mahalla.Domain.Enumes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalla.Domain.Entities
{
    public  class Odam
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public int HomeNumber {  get; set; }
        public int Age {  get; set; }
        public string Number {  get; set; }
        public Male OdamMale { get; set; }


        [ForeignKey(nameof(Oila))]
        public int OilaId { get; set; }
        public Oila Oila { get; set; }  
    }
}
