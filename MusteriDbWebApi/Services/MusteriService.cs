using MusteriDbWebApi.Models;
using MusteriDbWebApi.Data;

namespace MusteriDbWebApi.Services;

public class MusteriService
{
    private readonly MusteriDbContext _veritabani;

    public MusteriService(MusteriDbContext veritabani)
    {
        _veritabani = veritabani;
    }

    public List<Musteri> MusteriGetir()
    {
        return _veritabani.Musteriler.ToList();
    }
}
