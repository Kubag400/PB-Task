using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PB_Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressBookController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Test";
        }
    }
}

