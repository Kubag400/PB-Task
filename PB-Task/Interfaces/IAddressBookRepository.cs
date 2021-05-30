using PB_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PB_Task.Interfaces
{
    public interface IAddressBookRepository
    {
        Task<bool> InsertToAddressBookAsync(Address address);
    }
}
