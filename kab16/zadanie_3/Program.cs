using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;//sustem.web.extensions- ссылка!
using System.Net.Http;

namespace zadanie_3
{
    class Pair
    {
        public int x;
        public int y;

        public override bool Equals(object o)//сравнили 
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            Pair pair = (Pair)o;
            if (x != pair.x) return false;
            return y == pair.y;

        }
        public override int GetHashCode()//сравнили код объекта
        {
            int result = x;
            result = 31 * result + y;//формула из какойто умной головы 
            return result;
        }

    }
    class Message
    {
        public ISet<Pair> data = new HashSet<Pair>();
    }


    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Message mass = new Message();
            while (mass.data.Count < 1000)
            {
                int b = rnd.Next(0, 1000);
                int a = rnd.Next(- (int)Math.Sqrt(b), 1000);//int - чтобы не ругалось на минус
                mass.data.Add(new Pair { x = a, y = b }); // создаем пару с нашими данными 
            }
            string json = new JavaScriptSerializer().Serialize(mass);//преобразуем наш mass в строку.json (формат) бывает .xml

            HttpClient client = new HttpClient();
            StringContent content = new StringContent(json);//внимание на то что в скобках
            Uri adress = new Uri("http://localhost/handler7693.php");
            Task<HttpResponseMessage> response = client.PostAsync(adress, content);
            response.Wait();
            Task<string> responsString = response.Result.Content.ReadAsStringAsync();
            responsString.Wait();

            Console.WriteLine(responsString.Result + "ответ");
            Console.WriteLine(response.Result.StatusCode);

        }
    }
}


