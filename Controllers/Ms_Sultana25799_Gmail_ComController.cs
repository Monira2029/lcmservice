
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class Ms_Sultana25799_Gmail_ComController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] string x, [FromQuery] string y)
    {
        if (!int.TryParse(x, out int a) || !int.TryParse(y, out int b) || a <= 0 || b <= 0)
        {
            return Content("NaN", "text/plain");
        }

        int gcd(int m, int n)
        {
            while (n != 0)
            {
                int t = n;
                n = m % n;
                m = t;
            }
            return m;
        }

        long lcm = (long)a * b / gcd(a, b);
        return Content(lcm.ToString(), "text/plain");
    }
}
