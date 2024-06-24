using DependecyInjection.Context;
using DependecyInjection.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//<Interfaz, implementación>();
//builder.Services.AddSingleton<ICountryRepository, InMemoryRepository>(); //singleton: instancia única
builder.Services.AddScoped<ICountryRepository, FileCountryRepository>(); //instancia por ambito, en caso de controlador sería por request
//builder.Services.AddTransient<ICountryRepository, FileCountryRepository>(); //instancia por cada vez que es requerida

//instalar paquete de sqlserver
builder.Services.AddDbContext<CountryDbContext>((context) =>
{
    //primero poner appsettings.json
    context.UseSqlServer(builder.Configuration.GetConnectionString("CountryDb"));
});

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
