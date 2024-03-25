namespace GraTrojmiejska.API.Entities
{
    public class MapPoint
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =  string.Empty ;
        public required Coordinate Coordinate { get; set; }
    }
}
