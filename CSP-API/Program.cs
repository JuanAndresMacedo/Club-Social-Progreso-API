using BusinessLogic;
using BusinessLogic.Services.NewsFolder;
using BusinessLogic.Services.NewsFolder.Entities;
using DataBase.DataAccess.Context;
using DataBase.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; });

builder.Services.AddControllers();

var services = builder.Services;
services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});

var configuration = builder.Configuration;
var CSPConnectionString = configuration.GetConnectionString("CSP");
if (string.IsNullOrEmpty(CSPConnectionString))
{
    throw new Exception("Missing CSP connection string");
}

services.AddDbContext<DbContext, DBContext>(options => options.UseSqlServer(CSPConnectionString));

services.AddScoped<IRepository<News>, NewsRepository>();
services.AddScoped<INewsService, NewsService>();

services.AddScoped<IRepository<NewsContent>, Repository<NewsContent>>();

var app = builder.Build();

//app.UseHttpsRedirection();

app.UseCors(options =>
{
    options
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
});

app.UseAuthorization();

app.MapControllers();

app.Run();