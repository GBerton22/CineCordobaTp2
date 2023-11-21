using CineCordobaApi.Services.Implementacion;
using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Datos.Context;
using CineCordobaBack.Fachada.Concretas;
using CineCordobaBack.Fachada.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration.AddJsonFile("appsettings.json");
var configuration = builder.Configuration;


builder.Services.AddControllers();
builder.Services.AddScoped<IFuncionesServices, FuncionesServices>();
builder.Services.AddScoped<IPeliculaService, PeliculasService>();
builder.Services.AddScoped<IFuncionesDao, FuncionesDao>();
builder.Services.AddScoped<IDaoPeliculas, DaoPeliculas>();
builder.Services.AddScoped<ISalasServices, SalasServices>();
builder.Services.AddScoped<IHorariosServices, HorariosServices>();
builder.Services.AddScoped<IDaoSala, DaoSalas>();
builder.Services.AddScoped<IDaoHorario, DaoHorarios>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbContexto>(options =>
{
    AppContext.SetSwitch("System.Net.Security.SslStream.UseSslChain", true);

    options.UseSqlServer(configuration.GetConnectionString("Cordoba_Cine_GRUPO_N9"));
});

var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyHeader();
    options.AllowAnyMethod();
});

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
