using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator
{
    public class Calculate
    {
        public double Operations(double inp1, double inp2, string type)
        {

            switch(type)
            {
                case "Add":
                    return inp1 + inp2;
                  
                case "Sub":
                    return inp1 - inp2;
                   
                case "Mul":
                    return inp1 * inp2;
                    
                case "Div":
                    return inp1 / inp2;
                default:
                    return 0;
            }
        }
    }
}