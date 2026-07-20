using Microsoft.EntityFrameworkCore;
using MusteriDbWebApi.Models;

namespace MusteriDbWebApi.Data;
// EF Core’un veritabanı ile konuştuğu sınıftır.

public class MusteriDbContext : DbContext // Db Context, EF Core'un hazır DbContext class'ından miras alıyor.
{   
    // Constructor kısmı:
    public MusteriDbContext(DbContextOptions <MusteriDbContext> ayarlar) : base(ayarlar)
    {
    }

    public DbSet<Musteri> Musteriler { get; set; }
    public DbSet<MusteriAdresi> MusteriAdresleri { get; set; }
    public DbSet<MusteriIletisimBilgisi> MusteriIletisimBilgileri { get; set; }

    protected override void OnModelCreating(ModelBuilder modelOlusturucu)
    {
        modelOlusturucu.Entity<MusteriAdresi>() // EF Core'da bir entity (varlık) için ilişkileri tanımlamak için kullanılır.
            .HasOne(adres => adres.Musteri)
            .WithMany(musteri => musteri.Adresler)
            .HasForeignKey(adres => adres.CustomerId); // Foreign key ilişkisi kuruldu.
        modelOlusturucu.Entity<MusteriIletisimBilgisi>()
            .HasOne(iletisim => iletisim.Musteri)
            .WithMany(musteri => musteri.IletisimBilgileri)
            .HasForeignKey(iletisim => iletisim.CustomerId); // Bu bağlantı CustomerId alanı üzerinden kurulur.
    }
}