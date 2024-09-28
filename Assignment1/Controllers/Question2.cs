using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2 : ControllerBase
    {
        /// <summary>
        /// To get the greeting with the name of the user included in it.
        /// </summary>
        /// <param name="name">The name of the user.</param>
        /// <returns>"Hi name!"</returns>
        /// <example>
        /// GET: api/q2/greeting?name="Veerpal" -> Hi Veerpal!
        /// </example>
        [HttpGet(template: "Greeting")]

        public string Greeting(string name)
        {
            string greetingMsg = $"Hi {name}!";
            return greetingMsg;
        }
    }
}
