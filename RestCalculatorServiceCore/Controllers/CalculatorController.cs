using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCalculatorServiceCore.Model;

namespace RestCalculatorServiceCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET: api/Calculator
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Calculator/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Calculator
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Calculator/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST: api/Calculator
        [HttpPost("Add", Name = "Add")]
        public int Post([FromBody] Data data)
        {
            return data.A + data.B;
        }

        // POST: api/Calculator
        [HttpPost("Sub", Name = "Sub")]
        public int Sub([FromBody] Data data)
        {
            return data.A - data.B;
        }

        // POST: api/calculator
        [HttpPost("mul", Name = "mul")]
        public int Mul([FromBody] Data data)
        {
            return data.A * data.B;
        }
        
        // POST: api/calculator
        [HttpPost("div", Name = "div")]
        public double Div([FromBody] Data data)
        {
            if (data.B != 0)
            {
                return (1.0 * data.A) / data.B;
            }
            else throw new DivideByZeroException("Division by zero");
            //return data.A / data.B;
        }
    }
}
