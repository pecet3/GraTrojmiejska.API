using GraTrojmiejska.API.Entities;

namespace GraTrojmiejska.API.Dtos
{
    public record class SummaryMapPointDto
        (
        string Id,
        string Name,
        string Description,
        string Location,
        decimal Latitude,
        decimal Longitude,
        string CurrentOwnerId,
        DateTime? LastCapturedAt,
        ICollection<MapPointHistoryElement>? History
        );

}
