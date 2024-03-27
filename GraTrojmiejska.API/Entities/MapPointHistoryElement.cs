namespace GraTrojmiejska.API.Entities
{
    public class MapPointHistoryElement
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string MapPointId { get; set; } = string.Empty;
        public string OwnerId { get; set; } = string.Empty;
        public uint AchievedScore { get; set; }
        public DateTime CapturedAt { get; set; } 
        public DateTime EndedAt { get;set; }
        public required MapPoint MapPoint { get; set; }

    }
}
