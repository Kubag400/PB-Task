using Microsoft.EntityFrameworkCore;
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
        public async Task<bool> InsertToAddressBookAsync(AddressToAdd address)
        {
            var isAvailable = await _context.Addresses.Where(x=>x.PhoneNumber==address.PhoneNumber).FirstOrDefaultAsync();

            if (isAvailable==null)
            {
                var newAddress = new AddressDb
                {
                    FirstName = address.FirstName,
                    LastName = address.LastName,
                    City = address.City,
                    PhoneNumber = address.PhoneNumber
                };
                 _context.Addresses.Add(newAddress);
                var inserted = await _context.SaveChangesAsync();
                return inserted > 0;
            }
            return false;
        }
        public async Task<List<AddressDb>> FindByCityAsync(string city)
        {
            return await _context.Addresses.Where(x => x.City == city).ToListAsync();
        }

        public async Task<AddressDb> GetLastAddress()
        {
            var count = await _context.Addresses.CountAsync();
            return _context.Addresses.ToArray().LastOrDefault();
        }
    }
}
