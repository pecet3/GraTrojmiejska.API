using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using System.Runtime.CompilerServices;

namespace GraTrojmiejska.API.Mapping
{
    public static class MapPointMapping
    {
        public static MapPoint ToEntity(this CreateMapPointDto mapPointDto)
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

        public static MapPoint ToDto(this MapPoint mapPoint)
        {
            return new SummaryMapPointDto()
            {
                Id = mapPoint.Id,
                Name = mapPoint.Name,
                Description = mapPoint.Description,
                Latitude = mapPoint.Coordinate.Latitude,

            }
        }
    }
   
}
