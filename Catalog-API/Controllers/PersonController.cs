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
        [HttpGet("GetAll")]
        public List<Person> GetAllPeople()
        {
            var data = _personService.GetAllPerson();
            return data.ToList();

        }
        [HttpGet("GetPersonById")]
        public Person GetPersonById(int id)
        {
            try
            {
                return _personService.GetPersonById(id);

            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpDelete("DeletePerson")]
        public bool DeletePerson(int id)
        {
            try
            {
                _personService.DeletePerson(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPut("UpdatePerson")]
        public bool UpdatePerson(Person person)
        {
            try
            {
                _personService.UpdatePerson(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpGet("SearchPerson")]

        public async Task SearchPersonAsync(string name)
        {
            try
            {

                await _personService.SearchByName(name);
                //return true;

            }
            catch(Exception ex)
            {
               
                throw ex;
            }
        }
    }
}
