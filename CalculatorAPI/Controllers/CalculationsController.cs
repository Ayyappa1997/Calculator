using CalculatorAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CalculatorAPI.Controllers
{
    
    public class CalculationsController : ApiController
    {
        
        [Route("api/Calculate/Add/{operand1}/{operand2}")]
        [BasicAuthentication]
        public double GetAdd(double operand1, double operand2)
        {
            return (operand1 + operand2);
        }
       
        [Route("api/Calculate/Sub/{operand1}/{operand2}")]
        [BasicAuthentication]
        public double GetSub(double operand1, double operand2)
        {
            return (operand1 - operand2);
        }

        [Route("api/Calculate/Mul/{operand1}/{operand2}")]
        [BasicAuthentication]
        public double GetMul(double operand1, double operand2)
        {
            return (operand1 * operand2);
        }

        [Route("api/Calculate/Div/{operand1}/{operand2}")]
        [BasicAuthentication]
        public double GetDiv(double operand1, double operand2)
        {
            return (operand1 / operand2);
        }
    }
}
