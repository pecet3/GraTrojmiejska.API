using GraTrojmiejska.API.Data;
using GraTrojmiejska.API.Endpoints;
using GraTrojmiejska.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connString = builder.Configuration.GetConnectionString("Database");

builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(connString));


builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);

builder.Services.AddAuthorizationBuilder();


builder.Services.AddIdentityCore<AuthUser>()
    .AddEntityFrameworkStores<DataContext>()
    .AddApiEndpoints();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapIdentityApi<AuthUser>();

app.UseHttpsRedirection();


app.MapEndpointsGame();
app.MapEndpointsMapPoints();


await app.MigrateDbAsync();

app.Run();
