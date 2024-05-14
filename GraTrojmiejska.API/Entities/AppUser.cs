using Microsoft.AspNetCore.Identity;

namespace GraTrojmiejska.API.Entities
{
     class  AppUser: IdentityUser
    {
        public required string Name { get; set; }

    }

}
