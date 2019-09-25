using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestCalculatorConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            string addsum = AsyncAdd("Add",new Data(5, 5)).Result;
            Console.WriteLine(addsum);

            Console.ReadKey();
        }

        public static async Task<string> AsyncAdd(string urlext, Data data)
        {
            using (HttpClient client = new HttpClient())
            {
                string CalculatorUri = "https://localhost:44301/api/calculator/";
                Console.WriteLine("Data " + data);

                var jsonString = JsonConvert.SerializeObject(data);
                Console.WriteLine("json string: " + jsonString);

                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                Console.WriteLine("content: : " + content.ToString());
                Console.WriteLine("CalculatorUri: " + CalculatorUri);

                HttpResponseMessage response = await client.PostAsync(CalculatorUri + urlext, content);
                string str = await response.Content.ReadAsStringAsync();
                //Int32 sumStr = JsonConvert.DeserializeObject<Int32>(str);
                return str;
            }
        }

    }
}
