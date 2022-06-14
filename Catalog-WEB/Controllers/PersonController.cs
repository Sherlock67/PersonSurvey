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


    }
}
