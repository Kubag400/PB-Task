using Microsoft.EntityFrameworkCore;
using PB_Task.Models;

namespace PB_Task.Data
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext(DbContextOptions<AddressBookContext> options) : base(options)
        {
        }
        public DbSet<AddressDb> Addresses { get; set; }
    }
}
