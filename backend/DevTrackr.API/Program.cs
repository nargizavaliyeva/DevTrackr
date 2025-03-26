using DevTrackr.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register the DbContext with dependency injection
builder.Services.AddDbContext<DevTrackrContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DevTrackrDatabase")));


// Add other services
// ...

var app = builder.Build();

// Configure the HTTP request pipeline
// ...

app.Run();
