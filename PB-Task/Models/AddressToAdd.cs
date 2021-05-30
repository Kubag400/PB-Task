using System.ComponentModel.DataAnnotations;

namespace PB_Task.Models
{
    public class AddressToAdd
    {
        [Required]
   
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string City { get; set; }
    }
}
