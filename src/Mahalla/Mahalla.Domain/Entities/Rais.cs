using Mahalla.Domain.Enumes;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mahalla.Domain.Entities
{
    public class Rais
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }    
        public string Number {  get; set; }
        public string Email { get; set; }
        public Male RaisMale { get; set; }


        [ForeignKey(nameof(MahallaKamitet))]
        public int MahallaKamitetId { get; set; }
        public MahallaKamitet MahallaKamitet { get; set; }

    }
}
