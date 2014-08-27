using MVCNGAjax.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNGAjax.Controllers
{
    public class HomeController : Controller
    {
        EventsRepository eventsRepository = new EventsRepository();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Events()
        {
            return View();
        }
        public ActionResult bindingexample()
        {
            return View();
        }
        public ActionResult GetTalkDetails()
        {
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(eventsRepository.GetTalks(), settings),
                ContentType = "application/json"
            };

            return jsonResult;
        }
    }
}