using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator
{
    public class Calculate
    {
       public double Add(double inp1, double inp2)
        {
            return inp1 + inp2;
        }
        public double Sub(double inp1, double inp2)
        {
            return inp1 - inp2;
        }
        public double Mul(double inp1, double inp2)
        {
            return inp1 * inp2;
        }
        public double Div(double inp1, double inp2)
        {
            return inp1 / inp2;
        }        
    }
}
