namespace GraTrojmiejska.API.Dtos
{
    public record class AntiCheatDto
        (
        string MapPointId,
        string UserId,
        CoordinateDto UserCurrentCoordinate
        );
}
