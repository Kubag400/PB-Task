using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<AddressBookController> _logger;
        public AddressBookController(IAddressBookRepository repository, ILogger<AddressBookController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpPost(ApiRoutes.AddressBook.Add)]
        public async Task<IActionResult> InsertAddressToBook([FromBody] AddressToAdd address)
        {
            _logger.LogInformation("InsertAddressToBook invoked...");
            if (ModelState.IsValid)
            {
                bool insert = await _repository.InsertToAddressBookAsync(address);
                if (insert)
                {
                    _logger.LogInformation("Successfully!");
                    return Ok();
                }
                _logger.LogError("An error has occured - phone number already exists");
                return Conflict("Phone number already exists!");
            }
            _logger.LogError("An error has occured - insert value correctly");
            return BadRequest("Insert value correctly");
        }
        [HttpGet(ApiRoutes.AddressBook.FindByCity)]
        public async Task<ActionResult<List<AddressDb>>> FindByCity(string city)
        {
            _logger.LogInformation("FindByCity invoked...");
            if (!string.IsNullOrEmpty(city))
            {
                var result=await _repository.FindByCityAsync(city);
                if(result.Count>0)
                {
                    _logger.LogInformation("Sucessfully!");
                    return result;
                }
            }
            _logger.LogError("An error has occured - city not found");
            return NotFound("City not found!");
        }
        [HttpGet(ApiRoutes.AddressBook.GetLastAddress)]
        public async Task<ActionResult<AddressDb>> GetLastAddress()
        {
            _logger.LogInformation("GetLastAddress invoked...");
            var lastAddress = await _repository.GetLastAddress();
            if (lastAddress != null)
            {
                _logger.LogInformation("Sucessfully!");
                return lastAddress;
            }
            _logger.LogError("An error has occured - db is empty");
            return NotFound("Db is empty!");
        }

    }
}

