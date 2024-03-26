﻿using GraTrojmiejska.API.Data;
using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using GraTrojmiejska.API.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GraTrojmiejska.API.Endpoints
{
    public static class MapPoints
    {
        const string GetMapPoints = "GetMapPoint";
        public static RouteGroupBuilder MapEndpointsMapPoints(this WebApplication app)
        {
            var group = app.MapGroup("map-points");

            group.MapGet("/", async (DataContext dbContext) =>
              await dbContext.MapPoints
              .AsNoTracking()
              .ToListAsync()
            );


            group.MapPost("/", async (CreateMapPointDto newMapPoint, DataContext dbContext) =>
            {
                MapPoint mapPoint = newMapPoint.ToEntity();

                dbContext.MapPoints.Add(mapPoint);
                await dbContext.SaveChangesAsync();

                return Results.CreatedAtRoute(GetMapPoints, new { id = mapPoint.Id }, mapPoint);
            });

            group.MapGet("/{id}", async (int id, DataContext dbContext) =>
            await dbContext.MapPoints
            .AsNoTracking()
            .ToListAsync()

            ).WithName(GetMapPoints);

            return group;
        }
    }
}
