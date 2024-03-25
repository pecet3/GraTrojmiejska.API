namespace GraTrojmiejska.API.Entities
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string Name { get; set; }   
        public required Coordinate Coordinate { get; set; }


    }
}
