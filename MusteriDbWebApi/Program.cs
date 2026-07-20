using Microsoft.EntityFrameworkCore;
using MusteriDbWebApi.Data;
using MusteriDbWebApi.Services;

var builder = WebApplication.CreateBuilder(args); // Hazýrlýk aþamasýnda WebApplicationBuilder sýnýfýný kullanarak uygulama yapýlandýrmasýný baþlatýyoruz.

builder.Services.AddDbContext<MusteriDbContext>(ayarlar => // MusteriDbContext sýnýfýný dependency injection (DI) ile ekliyoruz.
    ayarlar.UseSqlServer(builder.Configuration.GetConnectionString("MusteriDbBaglantisi"))); // Baðlantý stringini appsettings.json dosyasýndan alýyoruz.

// 
builder.Services.AddScoped<MusteriService>(); // Projede MusteriService sýnýfýný kullanabilmek için dependency injection (DI) ile ekliyoruz.
//

builder.Services.AddControllers(); // API controller'larýný kullanabilmek için gerekli servisleri ekliyoruz.
builder.Services.AddOpenApi();


var app = builder.Build(); // Yaptýðýmýz ayarlarý kullanarak api uygulamasýný oluþturuyoruz.

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // Controller’lardaki route’larý dýþarý aç.

app.Run(); // Uygulamayý baþlatýyoruz ve gelen istekleri dinlemeye baþlýyoruz.