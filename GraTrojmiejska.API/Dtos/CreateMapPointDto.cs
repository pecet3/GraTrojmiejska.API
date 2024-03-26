using System.ComponentModel.DataAnnotations;

namespace GraTrojmiejska.API.Dtos
{
    public record class CreateMapPointDto
        (
        [Required] string Name,
        [Required] string Description,
        [Required] decimal Latitude,
        [Required] decimal Longtude
        );
}
