using Microsoft.AspNetCore.Mvc;
using PB_Task.Helpers;
using PB_Task.Interfaces;
using PB_Task.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PB_Task.Controllers
{

    public class AddressBookController : Controller
    {
        private readonly IAddressBookRepository _repository;
        public AddressBookController(IAddressBookRepository repository)
        {
            _repository = repository;
        }
        [HttpPost(ApiRoutes.AddressBook.Add)]
        public async Task<IActionResult> InsertAddressToBook([FromBody] AddressToAdd address)
        {
            if (ModelState.IsValid)
            {
                bool insert = await _repository.InsertToAddressBookAsync(address);
                if (insert)
                {
                    return Ok();
                }
                return BadRequest();
            }
            return Conflict("PhoneNumer");
        }
        [HttpGet(ApiRoutes.AddressBook.FindByCity)]
        public async Task<List<AddressDb>> FindByCity(string city)
        {
            if (!string.IsNullOrEmpty(city))
            {
                return await _repository.FindByCityAsync(city);
            }
            return null;
        }
        [HttpGet(ApiRoutes.AddressBook.GetLastAddress)]
        public async Task<AddressDb> GetLastAddress()
        {
            var lastAddress = await _repository.GetLastAddress();
            if(lastAddress!=null)
            {
                return lastAddress;
            }
            return null;
        }
     
    }
}

