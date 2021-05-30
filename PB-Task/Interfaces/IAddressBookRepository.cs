using PB_Task.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PB_Task.Interfaces
{
    public interface IAddressBookRepository
    {
        Task<bool> InsertToAddressBookAsync(AddressToAdd address);
        Task<List<AddressDb>> FindByCityAsync(string city);
        Task<AddressDb> GetLastAddress();
    }
}
