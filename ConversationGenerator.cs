using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;



namespace KanyeAndRon
{
    class ConversationGenerator
    {
        public static void KanyeTalks()
        {
            string kanyeURL = "https://api.kanye.rest";
            var client1 = new HttpClient();
            var kanyeResponse = client1.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine("_________________________________________________");
            Console.WriteLine($"Kanye says: {kanyeQuote}");
            Console.WriteLine("_________________________________________________");
        }



        public static void RonTalks()
        {
            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var client2 = new HttpClient();
            var ronResponse = client2.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            

            Console.WriteLine("_________________________________________________");
            Console.WriteLine($"Ron says: {ronQuote}");
            Console.WriteLine("_________________________________________________");
        }
    }
}
