using BOC.Areas.Mobile.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nancy.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace BOC.Areas.Mobile.Controllers
{
    [Area("Mobile")]
    public class FlightDateController : Controller
    {
        [HttpGet]
        public IActionResult Index(LoungeModel model) 
        {
            //Create viewbag content Route
            
            IEnumerable<SelectListItem> Routing = new[]
            {

                new SelectListItem { Value = "ALL", Text = "ALL" },
                new SelectListItem { Value = "INT", Text = "INT" },
                new SelectListItem { Value = "DOM", Text = "DOM" },

            };

            ViewBag.List = Routing;
            //Get Session Token
            var token = HttpContext.Session.GetString("Token");
            //Access API with Header
            Url airportlst = new Url();
            string uri = airportlst.Get("AirportList");


            HttpClient Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", token);
            var req = new HttpRequestMessage(HttpMethod.Post, uri);

            string Content;
            HttpResponseMessage res;
            res = Client.SendAsync(req).Result;
            Content = res.Content.ReadAsStringAsync().Result;
            var oData = JObject.Parse(Content);

            //Bind Json To List 
            JavaScriptSerializer ser = new JavaScriptSerializer();
            List<AirportList> lst = ser.Deserialize<List<AirportList>>(oData["Data"].ToString());//str is JSON string.
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].ID = i + 1;
            }
            model.ListAirport = lst;
            return View(model);
        }
        [HttpPost]
        public IActionResult Detail(LoungeModel model)
        {
            
 
            return View();

            

        }
    }
}
