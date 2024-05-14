using GraTrojmiejska.API.Entities;

namespace GraTrojmiejska.API.Dtos
{
    public record class ToDoTask
        (
        string Id,
        string Name,
        string Description,
        bool   IsCompleted
        );

}
