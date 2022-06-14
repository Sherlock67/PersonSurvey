using Catalog_BusinessLayer.Services;
using Catalog_DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        public readonly PersonService _personService;
        public PersonController(PersonService personService)
        {
            _personService = personService;
        }
        [HttpPost("AddPerson")]

        public async Task<object> CreateNewPerson([FromBody] Person person)
        {
            try
            {
                return await _personService.CreatePerson(person);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
