using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PB_Task.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
    }
}
