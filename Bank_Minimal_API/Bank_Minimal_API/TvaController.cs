using Microsoft.AspNetCore.Mvc;

namespace Bank_Minimal_API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvaController : ControllerBase
    {
        [HttpGet]
        public double CalculateTva(double price, string country)
        {
            double tvaRate = country == "BE" ? 0.21 : 0.20; // Taux de TVA pour BE et FR

            double tva = price * tvaRate;

            double total = price + tva;

            return total;
        }
    }
}
