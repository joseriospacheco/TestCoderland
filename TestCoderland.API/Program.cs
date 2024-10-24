using Microsoft.EntityFrameworkCore;
using TestCoderland.Core.Abstractions.Repositories;
using TestCoderland.Core.Abstractions.Services;
using TestCoderland.Core.Services;
using TestCoderland.Infrastructure.Data;
using TestCoderland.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<CoderlandDbContext>(opc => opc.UseNpgsql("name=DefaultConnection"));

builder.Services.AddScoped<IMarcaAutoRepository, MarcaAutoRepository>();
builder.Services.AddScoped<IMarcaAutoService, MarcaAutoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
        c.RoutePrefix = string.Empty; // Para que Swagger esté disponible en la raíz
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();