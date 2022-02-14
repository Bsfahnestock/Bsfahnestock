using System.ComponentModel.DataAnnotations;

namespace CapstoneDemo1.Models
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Specialty { get; set; }
        [Required]
        
        public string StreetAddress{ get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
      public string Email { get; set; }
        [Required]
        public string About { get; set; }
    }
}
