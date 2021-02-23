using System;
using RestSharp;
using Newtonsoft.Json;

namespace RestingBface
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://swapi.dev/api/");

            RestRequest request = new RestRequest("people/1/Luke Skywalker");

            IRestResponse response = client.Get(request);

            Starwars People = JsonConvert.DeserializeObject<Starwars>(response.Content);

            Console.WriteLine(response.StatusCode);

            Console.ReadLine();



        }
    }
}
