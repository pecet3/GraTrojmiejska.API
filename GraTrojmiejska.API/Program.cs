using GraTrojmiejska.API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connString = builder.Configuration.GetConnectionString("Database");

builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(connString));

builder.Services.AddAuthorization();

/*builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
*/
builder.Services.AddIdentityApiEndpoints<MyUser>()
    .AddEntityFrameworkStores<DataContext>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapIdentityApi<MyUser>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

class MyUser : IdentityUser
{
    public int Test { get; set; }
}
