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
        public async Task<FeServerStats> GetServerStats()
        {
            var stats = await _dbContext.FeServerStats.FirstOrDefaultAsync();
            return stats;
        }
        public async Task<IList<FeOnlineChar>> GetOnlinePlayers()
        {
            var chars = await _dbContext.FeOnlineChars.ToListAsync();
            return chars;
        }
    }
}
