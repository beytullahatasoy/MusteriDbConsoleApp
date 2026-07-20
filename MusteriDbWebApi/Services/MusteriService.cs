using MusteriDbWebApi.Models;
using MusteriDbWebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace MusteriDbWebApi.Services;
// Veritabanı işlemlerini gerçekleştiren servis sınıfı
public class MusteriService
{
    private readonly MusteriDbContext _veritabani;

    public MusteriService(MusteriDbContext veritabani)
    {
        _veritabani = veritabani;
    }

    public List<Musteri> MusterileriGetir() // Birden fazla kayıt, liste döndürür.
    {
        return _veritabani.Musteriler.ToList();
    }
    public Musteri? IdIleMusteriGetir(int musteriId)
    {
        return _veritabani.Musteriler.FirstOrDefault(musteri => musteri.CustomerId == musteriId); // ilk kaydı dondurur
    }

    public Musteri? IdIleMusteriDetayGetir(int musteriId)
    {
        return _veritabani.Musteriler
            .Include(musteri => musteri.Adresler) // Musteri ile ilişkili adresleri de getirir
            .Include(musteri => musteri.IletisimBilgileri) // Musteri ile ilişkili iletişim bilgilerini de getirir
            .FirstOrDefault(musteri => musteri.CustomerId == musteriId);
    }

    public Musteri MusteriEkle(Musteri eklenecekMusteri)
    {
        eklenecekMusteri.CreatedAt = DateTime.Now;
        eklenecekMusteri.IsActive = true;

        _veritabani.Musteriler.Add(eklenecekMusteri);
        _veritabani.SaveChanges();

        return eklenecekMusteri;
    }
}