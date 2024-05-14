using GraTrojmiejska.API.Data;
using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using GraTrojmiejska.API.Mapping;
using GraTrojmiejska.API.Migrations;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Text;

namespace GraTrojmiejska.API.Endpoints
{
    public static class EndpointsUsers
    {

        public static RouteGroupBuilder MapUsers(this WebApplication app)
        {
            var group = app.MapGroup("users").RequireAuthorization();

            group.MapGet("create",
                  async (CreateUserDto dto, DataContext dbContext, ClaimsPrincipal user) =>
                  {

                      var userName = user.Identity?.Name;

                      var existingUser = await dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userName);

                      if (existingUser is null) return Results.NotFound("user");
                      return Results.Ok();
                  });

            return group;


        }
    }
}
