using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PB_Task.Data
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
