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
    public static class EndpointsGame
    {

        public static RouteGroupBuilder MapEndpointsGame(this WebApplication app)
        {
            var group = app.MapGroup("game").RequireAuthorization();

          /*  group.MapPost("attempt-capture",
                  async (AttemptCaptureDto dto, DataContext dbContext, ClaimsPrincipal user) =>
                  {
                      var existingMapPoint = await dbContext.MapPoints.FindAsync(dto.MapPointId);

                      if (existingMapPoint is null) return Results.NotFound("map point");


                      return Results.Accepted(dto.UserId);
                  });

            group.MapPost("capture-point",
               async (CaptureMapPointDto dto, DataContext dbContext, ClaimsPrincipal user) =>
            {
                var existingMapPoint = await dbContext.MapPoints.FindAsync(dto.MapPointId);

                if (existingMapPoint is null) return Results.NotFound("map point");

                var userName = user.Identity?.Name;

                var existingUser = await dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userName);

                if (existingUser is null) return Results.NotFound("user");


                var newHistoryElement = new MapPointHistoryElement
                {
                    MapPointId = existingMapPoint.Id,
                    OwnerId = existingUser.Id,
                    AchievedScore = 0,
                    CapturedAt = DateTime.Now,
                    EndedAt = DateTime.Now,
                    MapPoint = existingMapPoint
                };

                await dbContext.MapPointHistoryElement.AddAsync(newHistoryElement);
                
                dbContext.Entry(existingMapPoint)
                    .CurrentValues
                    .SetValues
                    (
                    existingMapPoint.CurrentOwnerId = existingUser.Id
                    ); ;


                await dbContext.SaveChangesAsync();
                var newMapPoint = await dbContext.MapPoints.FindAsync(dto.MapPointId);

                return Results.Accepted(dto.UserId);

            });

          
*/
            return group;


        }

   /*     public static RouteGroupBuilder MapHubs(this WebApplication app)
        {
            var group = app.MapGroup("game");
            group.MapHub<CaptureHub>("/anticheat");
            return group;
        }*/
    }
}
