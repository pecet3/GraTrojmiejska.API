using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace GraTrojmiejska.API.Mapping
{
    public static class UserMapping
    {
      /*  public static MapPoint ToEntity(this CreateMapPointDto mapPointDto)
        {
            return new MapPoint()
            {
                Name = mapPointDto.Name,
                Description = mapPointDto.Description,
                CreatedAt = new DateTime(),
                Coordinate = new Coordinate()
                {
                    Latitude = mapPointDto.Latitude,
                    Longitude = mapPointDto.Longitude,
                    Type = Coordinate.CoordianteType.MAP_POINT,
                },
                Location = mapPointDto.Location,
            };
        }

        public static SummaryMapPointDto ToDto(this MapPoint mapPoint)
        {
            return new (
                Id : mapPoint.Id,
                Name : mapPoint.Name,
                Description : mapPoint.Description,
                Location : mapPoint.Location,
                Latitude : mapPoint.Coordinate.Latitude,
                Longitude : mapPoint.Coordinate.Longitude,
                CurrentOwnerId: mapPoint.CurrentOwnerId,
                LastCapturedAt : mapPoint.LastCapturedAt,
                History: mapPoint.History
                );
        }*/
    }
   
}
