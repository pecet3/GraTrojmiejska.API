using GraTrojmiejska.API.Entities;

namespace GraTrojmiejska.API.Dtos
{
    public record class CaptureMapPointDto
        (
        string MapPointId,
        string UserId,
        CoordinateDto UserCurrentCoordinate
        );
   
}
