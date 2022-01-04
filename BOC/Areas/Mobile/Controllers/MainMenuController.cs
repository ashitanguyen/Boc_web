using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BOC.Areas.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Nancy.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Renci.SshNet;


namespace BOC.Areas.Mobile.Controllers
{
    [Area("Mobile")]
    public class MainMenuController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public MainMenuController(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            this.configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            MenuMobiModel model = new MenuMobiModel();
            //Get Session Token
            var token = HttpContext.Session.GetString("Token");
            //Access API with Header           
            Url menu = new Url();
            string uri = menu.Get("MenuMobiGet");
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

            List<Models.Info> lstparent = ser.Deserialize<List<Models.Info>>(oData["Data"].ToString());
            model.Data = lstparent;//  Bind list menu to model
            var arraybag = model.Data;
            foreach (var i in arraybag)
            {
                var FileName = i.FTP_FileName;
                if (FileName != "")
                {
                    DownloadFiles(FileName);
                }

            }

            ViewBag.Username=HttpContext.Session.GetString("Username");
            return View(model);
        }

        private void DownloadFiles(string FileName)
        {
            //Đọc file json lấy thông tin đăng nhập SFTP Server
            var Host = configuration["SFTP:Host"];
            var Port = configuration["SFTP:Port"];
            var Username = configuration["SFTP:Username"];
            var Password = configuration["SFTP:Password"];
            String RemoteFileName = "/upload/Mobile/" + FileName;
            String LocalDestinationFilename = "";
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            LocalDestinationFilename = Path.Combine(contentRootPath, "wwwroot", "images/Mobile/" + FileName);


            //Compare Time Create File In Local And SFTP
            DateTime timelocalfile = System.IO.File.GetCreationTime(LocalDestinationFilename);
            DateTime timesftpfile = System.IO.File.GetCreationTime(RemoteFileName);
            if (timelocalfile <= timesftpfile)
            {


                using (var sftp = new SftpClient(Host, Int16.Parse(Port), Username, Password))
                {
                    sftp.Connect();

                    using (var file = System.IO.File.OpenWrite(LocalDestinationFilename))
                    {
                        sftp.DownloadFile(RemoteFileName, file);
                    }

                    sftp.Disconnect();
                }
            }

        }
    }
}
