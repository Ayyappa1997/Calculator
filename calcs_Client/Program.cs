using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace calcs_Client
{
    class Program
    {       
        static void Main(string[] args)
        {
            string result = string.Empty; ;
            Calculate calculate = new Calculate();
            Console.WriteLine("Please Enter Input1");
            double inp1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Input2");
            double inp2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select the operation you want to perform \n 1.Add \n 2.Sub \n 3.Mul \n 4.Div");
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    result = calculate.Add(inp1, inp2).ToString();
                    break;
                case "2":
                    result = calculate.Sub(inp1, inp2).ToString();
                    break;
                case "3":
                    result = calculate.Mul(inp1, inp2).ToString();
                    break;
                case "4":
                    result = calculate.Div(inp1, inp2).ToString();
                    break;
                default:
                    Console.WriteLine("Please select appropriate option");
                    break;
            }
            Console.WriteLine("Result = {0}",result);
            Console.ReadKey();
        }
    }
}
