namespace GraTrojmiejska.API.Entities
{
    public class MapPoint
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =  string.Empty ;
        public string CurrentOwnerId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? LastCapturedAt { get; set; }
        public ICollection<MapPointHistoryElement> History { get; } = new List<MapPointHistoryElement>();

        public  Coordinate Coordinate { get; set; } = new Coordinate();
        public string Location {  get; set; } = string.Empty;

    }
}
