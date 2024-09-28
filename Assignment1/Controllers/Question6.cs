using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6 : ControllerBase
    {
        /// <summary>
        /// Take a number as the side of a regular hexagon and returns area.
        /// </summary>
        /// <param name="side">Taking double as parameter.</param>
        /// <returns>Return the area in "Double" number type.</returns>
        /// <example>
        /// GET api/q6/hexagon?side=8 -> 166.27687752661222
        /// GET api/q6/hexagon?side=15 -> 584.5671475544962
        /// </example>
        [HttpGet(template:"Hexagon")]
        public double Hexagon(double side)
        {
            double square = Math.Pow(side, 2);
            double sqrt = Math.Sqrt(3);
            double area = ((3 * sqrt)/2) * square;
            return area;
        }
    }
}
