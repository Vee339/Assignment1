using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3 : ControllerBase
    {
        /// <summary>
        /// Getting the cubes of the numbers 
        /// </summary>
        /// <param name="inputNum">An integer</param>
        /// <returns>Returns the cube of the number specified</returns>
        /// <example>
        /// GET: api/q3/cube/5 -> 125
        /// GET: api/q3/cube/10 -> 1000
        /// </example>
        [HttpGet(template:"Cube/{inputNum}")]
        public int Cube(int inputNum)
        {
            int result = inputNum * inputNum * inputNum;
            return result;
        }
    }
}
