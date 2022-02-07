using System.ComponentModel.DataAnnotations;

namespace CapstoneDemo1.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Comment { get; set; }

    }
}
