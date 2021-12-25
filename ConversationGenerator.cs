using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanyeWest
{
    public class ConversationGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var KanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"--------");
            Console.WriteLine($"Kayne: '{KanyeQuote}' ");
            Console.WriteLine($"--------");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronsResponse = client.GetStringAsync(ronURL).Result;

            var RonQuote = JArray.Parse(ronsResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"--------");
            Console.WriteLine($"Ron: '{RonQuote}' ");
            Console.WriteLine($"--------");

        }
    }
}
