using System.IO;
using System.Net;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Configuration;

namespace Weather.Controllers
{
    public class ForecastController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            return View(GetForecastWeather());
        }

        public Models.OneCallApi GetForecastWeather()
        {
            var jsonString = string.Empty;
            string url = $"{ConfigurationManager.AppSettings["OpenweatherApiUri"]}?lat={ConfigurationManager.AppSettings["lat"]}" +
                $"&lon={ConfigurationManager.AppSettings["lon"]}&exclude=current,minutely,hourly&appid={ConfigurationManager.AppSettings["ApiKey"]}" +
                $"&units={ConfigurationManager.AppSettings["Units"]}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<Models.OneCallApi>(jsonString);
        }
    }
}