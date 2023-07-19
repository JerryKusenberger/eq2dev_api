using eq2dev_api.Data;
using eq2dev_api.Models;
using Microsoft.EntityFrameworkCore;

namespace eq2dev_api.Services
{
    public class ServerStatsService : IServerStatsService
    {
        private readonly Eq2EmuDbContext _dbContext;
        public ServerStatsService(Eq2EmuDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<FeOnlineChar>> GetServerStats()
        {
            var stats = await _dbContext.FeOnlineChars.ToListAsync();
            return stats;
        }
    }
}
