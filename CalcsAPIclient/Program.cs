using System;
using System.Net.Http.Headers;
using System.Text;

namespace CalcsAPIclient
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.WriteLine("Please enter operand1");
            double opr1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter operand2");
            double opr2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please select the operation to perform");
            Console.WriteLine(" 1.Add \n 2.Sub \n 3.Mul \n 4.Div");
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    action = "Add";
                    break;
                case "2":
                    action = "Sub";
                    break;
                case "3":
                    action = "Mul";
                    break;
                case "4":
                    action = "Div";
                    break;
                default:
                    break;
            }
            var url = string.Format("{0}{1}{2}{3}{4}{5}", "http://localhost:63421/api/calculate/",action, "/", opr1,"/",opr2);

            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add
                (new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                string authInfo = Convert.ToBase64String(Encoding.Default.GetBytes("Ayyappa:Ayyappa97"));  
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authInfo);
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    result = Convert.ToDouble(data);
                    Console.WriteLine("Result {0}", result);
                }
                else
                {

                    Console.WriteLine("server error");
                }
                
                
                Console.ReadLine();
            }
            
        }
    }
}
