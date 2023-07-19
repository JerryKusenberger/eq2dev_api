using eq2dev_api.Models;
using Microsoft.EntityFrameworkCore;

namespace eq2dev_api.Data
{
    public partial class Eq2EmuDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Eq2EmuDbContext(DbContextOptions<Eq2EmuDbContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<FeOnlineChar> FeOnlineChars { get; set; }

    }
}
