using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(opt =>
{
    // Obtém a connectionString da configuration.
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); // O nome "DefaultConnection" é o nome da connection string que criamos.
});

var app = builder.Build();

app.MapControllers();

app.Run();