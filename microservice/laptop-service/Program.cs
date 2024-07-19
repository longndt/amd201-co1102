using laptop_service.Data;
using laptop_service.Repositories.Interfaces;
using laptop_service.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<laptop_serviceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("laptop_serviceContext") ??
    throw new InvalidOperationException("Connection string 'laptop_serviceContext' not found.")));

builder.Services.AddScoped<ILaptopRepository, LaptopRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
