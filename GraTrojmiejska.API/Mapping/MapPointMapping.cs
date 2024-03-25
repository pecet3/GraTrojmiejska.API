using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;

namespace GraTrojmiejska.API.Mapping
{
    public static class MapPointMapping
    {
        public static MapPoint ToEntity(this MapPointDto mapPointDto)
        {
            return new MapPoint()
            {
                Name = mapPointDto.Name,
                Description = mapPointDto.Description,
                CreatedAt = new DateTime(),
                Coordinate = new Coordinate()
                {
                    Latitude = mapPointDto.Latitude,
                    Longitude = mapPointDto.Longtude,
                    Type = Coordinate.CoordianteType.MAP_POINT,
                }
            };
        }
    }
}
/*public string Id { get; set; } = Guid.NewGuid().ToString();
public string Name { get; set; } = string.Empty;
public string Description { get; set; } = string.Empty;
public string CurrentOwnerId { get; set; } = string.Empty;
public DateOnly CreatedAt { get; set; }
public MapPointHistoryElement[] History { get; set; } =
{
            new MapPointHistoryElement()
        };

public Coordinate Coordinate { get; set; } = new Coordinate();*/
public Coordinate Coordinate { get; set; } = new Coordinate();*/