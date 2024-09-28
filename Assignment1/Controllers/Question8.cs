using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8 : ControllerBase
    {

        [HttpPost(template:"Squashfellows")]
        public string SquashFellows([FromForm] int small, [FromForm] int large)
        {
            double smlCost = 25.50;
            double lrgCost = 40.50;
            double tax = 0.13;
            double smlPrice = small * smlCost;
            double lrgPrice = large * lrgCost;
            double subTotal = smlPrice + lrgPrice;
            double totalTax = subTotal * tax;
            double total = subTotal + totalTax;
            return $"{small} Small @ ${smlCost} =${smlPrice}; {large} Large @ ${lrgCost}= ${lrgPrice}; Subtotal =${subTotal}; Tax = ${totalTax} HST;Total = ${total}";
        }
    }
}
