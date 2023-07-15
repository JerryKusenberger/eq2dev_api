using eq2dev_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace eq2dev_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ICharacterService _characterService;
        public TestController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet()]
        public IActionResult Index()
        {
            return Ok("success");
        }

        [HttpGet("characters")]
        public async Task<IActionResult> GetCharacters()
        {
            var characters = await _characterService.GetCharacters();
            return Ok(characters);
        }
    }
}
