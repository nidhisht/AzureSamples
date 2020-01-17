using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _02.webapp_consume_webapi.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using _02.webapp_consume_webapi.Configuration;

namespace _02.webapp_consume_webapi.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController(IOptions<ApplicationSettings> appSettings)
        {
            //Refer "ApplicationSettings" section in appsettings.json file
            AppSettings = appSettings.Value;
        }

        public ApplicationSettings AppSettings { get; set; }
        public async Task<IActionResult> Index()
        {
            List<CustomerModel> customers = new List<CustomerModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppSettings.BaseUri);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(AppSettings.MediaType));

                HttpResponseMessage httpResponseMessage = await client.GetAsync(AppSettings.RequestUri);

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