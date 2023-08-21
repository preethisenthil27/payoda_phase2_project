using HolidayPackages.Models;
using HolidayPackages.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HolidayPackagesContext>(
    optionsAction:options=>options.UseSqlServer(
        builder.Configuration.GetConnectionString("SQLConnection")
        )
    );
builder.Services.AddScoped<HolidayPackagesContext>();
builder.Services.AddScoped<IBook,BookingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

