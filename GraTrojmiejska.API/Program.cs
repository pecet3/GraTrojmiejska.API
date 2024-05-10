using GraTrojmiejska.API.Data;
using GraTrojmiejska.API.Endpoints;
using GraTrojmiejska.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var service = builder.Services;
service.AddEndpointsApiExplorer();
service.AddSwaggerGen();

var connString = builder.Configuration.GetConnectionString("Database");

service.AddDbContext<DataContext>(options => options.UseSqlite(connString));
service.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);

service.AddAuthorizationBuilder();

service.AddIdentityCore<AuthUser>()
    .AddEntityFrameworkStores<DataContext>()
    .AddApiEndpoints();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var webSocketOptions = new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromMinutes(2)
};

app.UseWebSockets(webSocketOptions);

app.MapIdentityApi<AuthUser>();

app.UseHttpsRedirection();

app.MapEndpointsGame();

// I know, it's a weird name
app.MapEndpointsMapPoints();


await app.MigrateDbAsync();

app.Run();
