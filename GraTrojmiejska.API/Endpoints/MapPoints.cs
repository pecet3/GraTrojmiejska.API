using GraTrojmiejska.API.Data;
using GraTrojmiejska.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraTrojmiejska.API.Endpoints
{
    public static class MapPoints
    {
        const string GetSoftwareEndpointName = "GetMapPoint";
        public static RouteGroupBuilder MapEndpointsMapPoints(this WebApplication app)
        {
            var group = app.MapGroup("map-points");

            group.MapGet("/", async (DataContext dbContext) =>
              await dbContext.MapPoints
              .AsNoTracking()
              .ToListAsync()
            );


            group.MapPost("/", async (MapPoint newMapPoint, DataContext dbContext) => 
                
            );
            return group;
        }
    }
}
