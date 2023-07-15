namespace eq2dev_api.Services
{
    public interface ICharacterService
    {
        Task<IList<Character>> GetCharacters();
    }
}
