using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A converstaion bewteen Kanye West and Ron Swanson might go something like this:");


            for (int i = 0; i <= 5; i++) 
            {
                ConversationGenerator.RonTalks();

                ConversationGenerator.KanyeTalks();
            }
        }
    }
}
