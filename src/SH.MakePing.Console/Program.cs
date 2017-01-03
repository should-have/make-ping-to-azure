using System;
using System.Net.Http;

namespace SH.MakePing.App
{
    class Program
    {
        const string _url = "{your_url}";
        static HttpClient _httpClient = new HttpClient();

        static void Main(string[] args)
        {
            var response = _httpClient.GetAsync(_url).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
