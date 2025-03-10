using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFIntroPD422.Entities
{
    //Clients
    //Flights
    //Aiplanes
    [Table("Passengers")]
    class Client
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        //[MaxLength(100)]
        [Column("FirstName")]

        public string Name { get; set; }
        [EmailAddress, Required]
        public string Email { get; set; }
        public DateTime? Birthdate { get; set; }
        //Navigation property
        public ICollection<Flight> Flights { get; set; }
    }
}
