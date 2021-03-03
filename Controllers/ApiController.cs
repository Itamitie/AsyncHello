using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AsyncHello.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AsyncHello.Controllers
{
    public class ApiController : Controller
    {
        public async Task<IActionResult> Info()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<ApiViewModel>(responseBody);

            return View(model);
        }
    }

}