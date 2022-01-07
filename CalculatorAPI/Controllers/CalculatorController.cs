using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [HttpGet("sub")]
        public int Sub(int a, int b)
        {
            return a - b;
        }

        [HttpGet("mult")]
        public int Mult(int a, int b)
        {
            return a * b;
        }

        [HttpGet("div")]
        public double Div(int a, int b)
        {
            return a / b;
        }
    }
}
