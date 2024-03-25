namespace GraTrojmiejska.API.Entities
{
    public class Coordinate
    {
        public enum CoordianteType
        {
            POINT,
            USER_POSITION
        }

       public string Id { get; set; } = Guid.NewGuid().ToString();
       public decimal Latitude { get; set; }  
       public decimal Longitude { get; set; }

       public CoordianteType Type { get; set; }
    }
}
