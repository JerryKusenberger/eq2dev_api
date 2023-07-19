namespace eq2dev_api.DTOs
{
    public record ServerStatsResponse
    {
        public int OnlinePlayers { get; init; }
        public int TotalCharacters { get; init; }
        public int TotalAccounts { get; init; }
        public int TotalGuilds { get; init; }
        public int TotalItems { get; init; }
        public int TotalNpcs { get; init; }

    }
}
