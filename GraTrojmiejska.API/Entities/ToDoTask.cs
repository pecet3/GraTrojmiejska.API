using GraTrojmiejska.API.Entities;

namespace NetWorkspace.API.Entities
{
    public class ToDoTask
    {
        int Id { get; set; }
        public required string Name { get; set; } 
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
