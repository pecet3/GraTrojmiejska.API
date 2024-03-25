namespace GraTrojmiejska.API.Entities
{
    public class MapPoint
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =  string.Empty ;
        public string CurrentOwnerId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public MapPointHistoryElement[] History { get; set; } =
        {
            new MapPointHistoryElement()
        };

        public  Coordinate Coordinate { get; set; } = new Coordinate();

    }
}
