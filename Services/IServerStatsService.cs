using eq2dev_api.Models;

namespace eq2dev_api.Services
{
    public interface IServerStatsService
    {
        Task<IList<FeOnlineChar>> GetServerStats();
    }
}
