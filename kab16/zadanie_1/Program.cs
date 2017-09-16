using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<int> numbers = new HashSet<int>();
            Random rnd = new Random();
            while (numbers.Count < 1000)
            {
                numbers.Add(rnd.Next(1, 10000));
            }
            String data = string.Join(";", numbers);
            //Console.WriteLine(data);//выведем наш set в формате строки на экран

            HttpClient client = new HttpClient();
            StringContent content = new StringContent(data);
            Uri adress = new Uri("http://localhost/handler2070.php");
            Task<HttpResponseMessage> response = client.PostAsync(adress, content);
            response.Wait();
            Task<string> responsString = response.Result.Content.ReadAsStringAsync();
            responsString.Wait();

            Console.WriteLine(responsString.Result+"ответ");
            Console.WriteLine(response.Result.StatusCode);

            //     work(data);
            // }
            //static  async void work (string data)
            //     {
            //     HttpClient client = new HttpClient();
            //     StringContent content = new StringContent(data);
            //     Uri adress = new Uri("http://localhost/handler2070.php");
            //     HttpResponseMessage response = await client.PostAsync(adress, content);

            //     string responsString = await response.Content.ReadAsStringAsync();
            //     Console.WriteLine(responsString);


            //     }

        }
    }
}

