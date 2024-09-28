using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7 : ControllerBase
    {
        /// <summary>
        /// Takes number of days and add it to today's date which is returned in the form of string.
        /// </summary>
        /// <param name="days">Days are taken as parameter in integer form.</param>
        /// <returns>return string "yyyy-MM-dd"</returns>
        /// <example>
        /// GET api/q7/timemachine?days=3 -> 2024-10-30
        /// </example>
        [HttpGet(template:"Timemachine")]
        public string Timemachine(int days)
        {
            DateTime today = DateTime.Now;
            DateTime daysAdded = today.AddDays(days);
            string date = daysAdded.ToString("yyyy-MM-dd");
            return date;
        }
    }
}
