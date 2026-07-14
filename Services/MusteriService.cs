using Microsoft.EntityFrameworkCore;
using MusteriDbConsoleApp.Data;
using MusteriDbConsoleApp.Models;

namespace MusteriDbConsoleApp.Services;

public class MusteriService
{
    private readonly MusteriDbContext _context; // DbContext nesnesi, veritabanı işlemlerini gerçekleştirmek için kullanılır.

    public MusteriService()
    {
        _context = new MusteriDbContext();
    }

    public List<Musteri> MusterileriGetir() // Tüm müşterileri veritabanından getirir ve bir liste olarak döndürür.
    {
        return _context.Musteriler.ToList();
    }

    public List<Musteri> MusterileriDetayliGetir()
    {
        return _context.Musteriler
            .Include(m => m.Adresler)
            .Include(m => m.IletisimBilgileri)
            .ToList();
    }
}
