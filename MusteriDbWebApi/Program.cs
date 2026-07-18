using Microsoft.EntityFrameworkCore;
using MusteriDbWebApi.Data;
using MusteriDbWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MusteriDbContext>(ayarlar =>
    ayarlar.UseSqlServer(builder.Configuration.GetConnectionString("MusteriDbBaglantisi")));

// 
builder.Services.AddScoped<MusteriService>(); // Scoped: Her HTTP isteði için yeni bir servis örneði oluþturur. Bu, genellikle veri tabaný iþlemleri için kullanýlýr, çünkü her istek kendi baðlamýna sahip olmalýdýr.
//

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
