using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace spacex_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = WebRequest.Create("https://api.spacexdata.com/v2/launches/upcoming");
            var response = request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var responseObject = JsonConvert.DeserializeObject<List<spacex_bot.responses.Launch>>(responseString);
            var diff = responseObject.First().launch_date_utc - DateTime.UtcNow ;
            var dateString = "";
            if(diff.TotalDays >= 1) dateString = $"{Math.Floor(diff.TotalDays)} days, ";
            dateString += diff.ToString("g");
            Console.WriteLine($"Next launch is in {dateString}");
        }
    }
}
