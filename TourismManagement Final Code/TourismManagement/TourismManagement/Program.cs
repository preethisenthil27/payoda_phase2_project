using Microsoft.EntityFrameworkCore;
using TourismManagement.Models;
using TourismManagement.Services;
using TourismManagement.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//4.step manual configration//
builder.Services.AddDbContext<TourismManagementContext>(
    optionsAction: options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("SQLServerConnection")));
//

builder.Services.AddScoped<IPackage, PackageService>();





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
