using Microsoft.AspNetCore.Mvc;
using PB_Task.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PB_Task.Controllers
{

    public class AddressBookController : Controller
    {
        [HttpGet(ApiRoutes.AddressBook.Add)]
        public string Get()
        {
            return "Test";
        }
    }
}

