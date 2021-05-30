using PB_Task.Interfaces;
using PB_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PB_Task.Services
{
    public class AddressBookRepository : IAddressBookRepository
    {
        public Task<bool> InsertToAddressBookAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
