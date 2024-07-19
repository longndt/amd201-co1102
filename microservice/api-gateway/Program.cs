//declare Ocelot libraries
using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//config Ocelot gateway
builder.Configuration.AddJsonFile(
  "gateway.json",
  optional: false,
  reloadOnChange: true
  );

//setup cache manager for Ocelot
builder.Services.AddOcelot(builder.Configuration).AddCacheManager(x =>
{
    x.WithDictionaryHandle();
});

var app = builder.Build();

app.UseHttpsRedirection();

//add Ocelot to container 
await app.UseOcelot();

app.Run();
