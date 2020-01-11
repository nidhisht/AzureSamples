using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _02.webapp_consume_webapi.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace _02.webapp_consume_webapi.Controllers
{
    public class CustomerController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<CustomerModel> customers = new List<CustomerModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://adventureworks162api.azurewebsites.net");

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = await client.GetAsync("api/customers");

                if(httpResponseMessage.IsSuccessStatusCode)
                {
                    var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    customers = JsonConvert.DeserializeObject<List<CustomerModel>>(response);
                }
            }

            return View(customers);
        }
    }
}