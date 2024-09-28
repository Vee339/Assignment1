using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5 : ControllerBase
    {
        /// <summary>
        /// Receives an integer in the body of the request and respond a string with integer embedded in it.
        /// </summary>
        /// <param name="bodyInput">An integer must be specified by the user.</param>
        /// <returns>Returns a string "Shh... the secret is {parameter}"</returns>
        /// <example>
        /// POST "34" api/q5/secret -> "Shh... the secret is 34"
        /// </example>
        [HttpPost(template: "Secret")]
        public string Secret([FromBody] int bodyInput)
        {
            return $"Shh... the secret is {bodyInput}";
        }
    }
}
