using PB_Task.Data;
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
        private readonly AddressBookContext _context;
        public AddressBookRepository(AddressBookContext context)
        {
            _context = context;
        }
        public Task<bool> InsertToAddressBookAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
