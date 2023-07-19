namespace eq2dev_api.Models
{
    public class FeOnlineChar
    {
        public int Class { get; set; }
        public int Race { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public string? CurrentZone { get; set; }
        public int CurrentZoneId { get; set; }
        public int AccountId { get; set; }
        public int LastClientVersion { get; set; }
        public string? IpAddress { get; set; }

    }
}
