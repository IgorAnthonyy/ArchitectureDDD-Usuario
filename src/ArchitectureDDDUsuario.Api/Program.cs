using ArchitectureDDDUsuario.Application.Services;
using ArchitectureDDDUsuario.Domain.Interfaces;
using ArchitectureDDDUsuario.Infrastructure;
using ArchitectureDDDUsuario.Infrastructure.Repositories;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMongoDb(builder.Configuration);

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<UsuarioService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
