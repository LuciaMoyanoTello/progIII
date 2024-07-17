using DependecyInjection2.Context;
using DependecyInjection2.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<ICountryRepository, FileCountryRepository>();
/*builder.Services.AddDbContext<CountryDbContext>((context) =>
{
    context.UseSqlServer(builder.Configuration.GetConnectionString("CountryDb"));
});*/

builder.Services.AddTransient<ICountryRepository, DbCountryRepository>();
//para api
builder.Services.AddSingleton<ICountryRepository, ApiCountryRepository>();
builder.Services.AddHttpClient("CountryApi", x =>
{
    //baseaddress es una url base
    x.BaseAddress = new Uri("https://restcountries.com/v3.1");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//CORS
app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyHeader();
    options.AllowAnyMethod();
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
