using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4 : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with an empty body and provides a response message.
        /// </summary>
        /// <returns>A message.</returns>
        /// <param>No parameter is used.</param>
        /// <example>POST api/q4/knockknock -> "Who's there?"</example>
        [HttpPost(template:"Knockknock")]
        public string Knockknock()
        {
            string msg = "Who's there?";
            return msg;
        }
    }
}
