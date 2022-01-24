using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DeviceDetectorNET;
using DeviceDetectorNET.Parser;
using DeviceDetectorNET.Cache;

namespace BOC.Areas.BaggageMiss.Controllers
{
    [Area("BaggageMiss")]
    public class CompletePagesController : Controller
    {
        private string userAgent;

        public IActionResult Index()
        {
            string lang = HttpContext.Request.Query["t_flag"].ToString();
            string bagmiss_id = HttpContext.Request.Query["t_bagmiss_id"].ToString();
            // OPTIONAL: Set version truncation to none, so full versions will be returned
            // By default only minor versions will be returned (e.g. X.Y)
            // for other options see VERSION_TRUNCATION_* constants in DeviceParserAbstract class
            // add using DeviceDetectorNET.Parser;
            DeviceDetector.SetVersionTruncation(VersionTruncation.VERSION_TRUNCATION_NONE);

            var dd = new DeviceDetector(userAgent);

            // OPTIONAL: Set caching method
            // By default static cache is used, which works best within one php process (memory array caching)
            // To cache across requests use caching in files or memcache
            // add using DeviceDetectorNET.Cache;
            dd.SetCache(new DictionaryCache());

            // OPTIONAL: If called, GetBot() will only return true if a bot was detected  (speeds up detection a bit)
            dd.DiscardBotInformation();

            // OPTIONAL: If called, bot detection will completely be skipped (bots will be detected as regular devices then)
            dd.SkipBotDetection();

            dd.Parse();

            if (dd.IsBot())
            {
                // handle bots,spiders,crawlers,...
                var botInfo = dd.GetBot();
            }
            else
            {
                //var clientInfo = dd.GetClient(); // holds information about browser, feed reader, media player, ...
                //var osInfo = dd.GetOs();
                //var device = dd.GetDeviceName();
                //var brand = dd.GetBrandName();
                //var model = dd.GetModel();
                var device = dd.GetDeviceName();
                if (device == "smartphone")
                {
                    return RedirectToAction("Index", "MPages", new { @t_flag = lang, @t_bagmiss_id=bagmiss_id });
                }
                else
                {
                    return RedirectToAction("Index", "Pages", new { @t_flag = lang, @t_bagmiss_id = bagmiss_id });
                }
                
            }

            return View();
        }

        


    }

}

