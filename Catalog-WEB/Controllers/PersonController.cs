using Catalog_DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Catalog_WEB.Controllers
{
    public class PersonController : Controller
    {
        private static string url = "https://localhost:7271/";
        [HttpGet]
        public IActionResult AddNewPerson()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewPerson(Person person)
        {
            string custommsg = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMsg = await client.PostAsJsonAsync("/api/v1/Person/AddPerson", person);
                if (responseMsg != null)
                {
                    var res = responseMsg.Content.ReadAsStringAsync().Result;
                    custommsg = JsonConvert.DeserializeObject<string>(res);
                }
            }
            return View();
        }

        public async Task<IActionResult> AllPerson()
        
        {
            List<Person> ListPeople = new List<Person>();
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMsg = await client.GetAsync("/api/v1/Person/GetAll");
                if(responseMsg != null)
                {
                    var res = responseMsg.Content.ReadAsStringAsync().Result;
                    ListPeople = JsonConvert.DeserializeObject<List<Person>>(res);
                }
            }
            return View(ListPeople);
        }
        public async Task<ActionResult> DeletePerson(int? id)
        {
            string custommsg = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMsg = await client.DeleteAsync("/api/v1/Person/DeletePerson?id=" + id);
                if (responseMsg.IsSuccessStatusCode)
                {
                    var res = responseMsg.Content.ReadAsStringAsync().Result;
                    custommsg = JsonConvert.DeserializeObject<string>(res);
                }
            }
            return RedirectToAction("AllPerson");
        }
        [HttpGet]
        public async Task<IActionResult> UpdatePerson(int id)
        {
            Person p = new Person();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var personId = await client.GetAsync("/api/v1/Person/GetPersonById?id=" + id);
                if (personId.IsSuccessStatusCode)
                {
                    var personList = personId.Content.ReadAsStringAsync().Result;
                    p = JsonConvert.DeserializeObject<Person>(personList);
                }

            }
            return View(p);

        }
        [HttpPost]
        public async Task<IActionResult> UpdatePerson(Person person)
        {

            string custommsg = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMsg = await client.PutAsJsonAsync("/api/v1/Person/UpdatePerson", person);
                if (responseMsg.IsSuccessStatusCode)
                {
                    var res = responseMsg.Content.ReadAsStringAsync().Result;
                    custommsg = JsonConvert.DeserializeObject<string>(res);
                }
            }
           
            return RedirectToAction("AllPerson");

        }

    }
}
