using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOC.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using Nancy.Json;
using Newtonsoft.Json;
using RestSharp;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BOC.Controllers
{
    public class BOCController : Controller
    {
        [HttpGet]
        public string Menu()
        {
            MenuModel model = new MenuModel();

            //Get Session Token
            var token = HttpContext.Session.GetString("Token");
            //Access API with Header           
            Url menu = new Url();
            string uri = menu.Get("MenuGet");
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

            List<Info> lstparent = ser.Deserialize<List<Info>>(oData["Data"].ToString());
            model.Data = lstparent;//  Bind list menu to model

            return Newtonsoft.Json.JsonConvert.SerializeObject(model.Data);
        }
        //public static List<string> InvalidJsonElements;
        [HttpGet]
        public IActionResult Index(LoungeModel model)
        {
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
    }
}

