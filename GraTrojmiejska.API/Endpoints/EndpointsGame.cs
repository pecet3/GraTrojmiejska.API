using GraTrojmiejska.API.Data;
using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using GraTrojmiejska.API.Mapping;
using GraTrojmiejska.API.Migrations;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GraTrojmiejska.API.Endpoints
{
    public static class EndpointsGame
    {
        public static RouteGroupBuilder MapEndpointsGame(this WebApplication app)
        {
            var group = app.MapGroup("game").RequireAuthorization();

            group.MapPost("map-points/capture",
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


                dbContext.Entry(existingMapPoint)
                    .CurrentValues
                    .SetValues
                    (
                    existingMapPoint.CurrentOwnerId = existingUser.Id
/*                    existingMapPoint =  existingMapPoint.History.ToList<MapPointHistoryElement>()
*/                    ); ;

                await dbContext.SaveChangesAsync();
                var newMapPoint = await dbContext.MapPoints.FindAsync(dto.MapPointId);

                return Results.Accepted(dto.UserId);

            });

            return group;
        }
    }
}
