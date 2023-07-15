using eq2dev_api.Data;
using Microsoft.EntityFrameworkCore;

namespace eq2dev_api.Services
{
    public class CharacterService : ICharacterService
    {
        public readonly Eq2EmuDbContext _dbContext;
        public CharacterService(Eq2EmuDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<Character>> GetCharacters()
        {
            FormattableString sql = $"SELECT * FROM eq2emu.characters";
            var characters = await _dbContext.Characters.ToListAsync();
            return characters;
        }
    }
}
