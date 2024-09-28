using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1 : ControllerBase
    {

        /// <summary>
        /// To get the welcome message with GET request.
        /// </summary>
        /// <returns>Always returns the "Welcome to 5125" string.</returns>
        ///<param>No parameter is required</param>
        ///<example>
        ///GET: api/q1/welcome -> "Welcome to 5125"
        /// </example>

        [HttpGet(template: "Welcome")]
        public string Welcome()
        {
            string welcomeMsg = "Welcome to 5125";
            return welcomeMsg;
        }
    }
}
