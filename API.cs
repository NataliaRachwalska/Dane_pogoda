using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dane_pogoda
{
    public class API
    {
        public HttpClient client;
        public async Task GetData()
        {
            client = new HttpClient();
            string call = "http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=790d009aaa18a4aa46f1271e72d613af";
            string response = await client.GetStringAsync(call);
            //Console.WriteLine(response);
            Weather_info.root info = JsonSerializer.Deserialize<Weather_info.root>(response);
            Console.WriteLine(info);
            
        }
        
    }
}