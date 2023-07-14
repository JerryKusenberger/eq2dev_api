using Microsoft.AspNetCore.Mvc;

namespace eq2dev_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet()]
        public IActionResult Index()
        {
            return Ok("success");
        }
    }
}
