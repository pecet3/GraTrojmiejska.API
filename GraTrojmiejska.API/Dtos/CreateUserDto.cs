using System.ComponentModel.DataAnnotations;

namespace GraTrojmiejska.API.Dtos
{
    public record class CreateUserDto
        (
        [Required] string Name
        );
}
