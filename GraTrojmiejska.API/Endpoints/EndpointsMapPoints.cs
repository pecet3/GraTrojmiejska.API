using GraTrojmiejska.API.Data;
using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using GraTrojmiejska.API.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GraTrojmiejska.API.Endpoints
{
    public static class EndpointsMapPoints
    {
        const string GetMapPoints = "GetMapPoint";
        public static RouteGroupBuilder MapEndpointsMapPoints(this WebApplication app)
        {
            var group = app.MapGroup("map-points");

            group.MapGet("/", async (DataContext dbContext) =>
            {
                ICollection<MapPoint> entities = await dbContext.MapPoints.AsNoTracking().ToListAsync();
                List<SummaryMapPointDto> dtos = new List<SummaryMapPointDto>();

                foreach (MapPoint entity in entities)
                {
                    var mapPoint = entity.ToDto();
                    dtos.Add(mapPoint);
                }
                return Results.Ok(dtos);
            });


            group.MapPost("/", async (CreateMapPointDto newMapPoint, DataContext dbContext) =>
            {
                MapPoint mapPoint = newMapPoint.ToEntity();

                dbContext.MapPoints.Add(mapPoint);
                await dbContext.SaveChangesAsync();

                return Results.CreatedAtRoute(GetMapPoints, new { id = mapPoint.Id }, mapPoint);
            });

            group.MapGet("/{id}", async (string id, DataContext dbContext) =>
            {
                var existingMapPoint = await dbContext.MapPoints.FindAsync(id);
                if (existingMapPoint is null) return Results.NotFound();

                SummaryMapPointDto mapPointDto = existingMapPoint.ToDto();

                return Results.Ok(mapPointDto);

            }
            ).WithName(GetMapPoints);

            return group;
        }
    }
}
