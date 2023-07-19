using eq2dev_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace eq2dev_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerStatsController : Controller
    {
        private readonly IServerStatsService _serverStatsService;
        public ServerStatsController(IServerStatsService serverStatsService)
        {
            _serverStatsService = serverStatsService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetServerStats()
        {
            var stats = await _serverStatsService.GetServerStats();
            return Ok(stats);
        }
    }
}
