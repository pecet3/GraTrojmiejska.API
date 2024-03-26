using GraTrojmiejska.API.Entities;

namespace GraTrojmiejska.API.Dtos
{
    public  record class SummaryMapPointDto(
        string Id,
        string Name,
        string Description,
        decimal Latitude,
        decimal Longtude,
        string CurrentOwnerId,
        string LastCapturedAt,
        ICollection<MapPointHistoryElement>? History
        );

}
