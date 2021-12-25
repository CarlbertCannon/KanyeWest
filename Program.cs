using KanyeWest;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversationGenerator.KanyeQuote();

            ConversationGenerator.RonQuote();

        }
    }
}
