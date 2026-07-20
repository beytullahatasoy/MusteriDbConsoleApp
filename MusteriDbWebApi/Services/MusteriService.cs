using MusteriDbWebApi.Models;
using MusteriDbWebApi.Data;

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
}