namespace GraTrojmiejska.API.Dtos
{
    public record class AttemptCaptureDto
        (
        string MapPointId,
        string UserId,
        CoordinateDto UserCurrentCoordinate
        );
}
