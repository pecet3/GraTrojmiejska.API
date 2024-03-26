using GraTrojmiejska.API.Data;
using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using GraTrojmiejska.API.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GraTrojmiejska.API.Endpoints
{
    public static class EndpointsGame
    {
        public static RouteGroupBuilder MapEndpointsGame(this WebApplication app)
        {
            var group = app.MapGroup("game");

            group.MapGet("/map-points/capture/{id}",
               async (string id, DataContext dbContext, ClaimsPrincipal user) =>
            {
               var existingMapPoint = await dbContext.MapPoints.FindAsync(id);

                if (existingMapPoint == null)
                {
                    return Results.NotFound();
                }

                dbContext.Entry(existingMapPoint)
                    .CurrentValues
                    .SetValues(existingMapPoint);

                await dbContext.SaveChangesAsync();

                return Results.Accepted();

            }).RequireAuthorization();

            return group;
        }
    }
}
