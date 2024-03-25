using Microsoft.AspNetCore.Identity;

namespace GraTrojmiejska.API.Entities
{
     class AuthUser: IdentityUser
    {  
    }

    class GameUser 
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string Name { get; set; } 
        public Coordinate CurrentPosition { get; set; } = new Coordinate();

    }
}
