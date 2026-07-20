using Microsoft.AspNetCore.Mvc;
using MusteriDbWebApi.Services;
using MusteriDbWebApi.Models;

namespace MusteriDbWebApi.Controllers;
// Dışarıdan gelen HTTP isteklerini karşılamak için kullanılan API controller sınıfı

[ApiController]
[Route("api/[controller]")]
public class MusterilerController : ControllerBase
{
    private readonly MusteriService _musteriServisi;
    public MusterilerController(MusteriService musteriServisi)
    {
        _musteriServisi = musteriServisi;
    }

    [HttpGet]
    public ActionResult<List<Musteri>> MusterileriGetir()
    {
        var musteriler = _musteriServisi.MusterileriGetir();

        return Ok(musteriler);
    }

    [HttpGet("{musteriId}")]
    public ActionResult<Musteri> IdIleMusteriGetir(int musteriId)
    {
        var musteri = _musteriServisi.IdIleMusteriGetir(musteriId);

        if (musteri == null) 
        { 
            return NotFound($"{musteriId} ID degerine sahip musteri bulunamadi.");
        }

        return Ok(musteri);
    }

    [HttpGet("{musteriId}/detay")]
    public ActionResult<Musteri> IdIleMusteriDetayGetir(int musteriId)
    {
        var musteri = _musteriServisi.IdIleMusteriDetayGetir(musteriId);
        if (musteri == null) 
        { 
            return NotFound($"{musteriId} ID degerine sahip musteri bulunamadi.");
        }

        var musteriDetay = new 
        {
            musteri.CustomerId,
            musteri.FirstName,
            musteri.LastName,
            musteri.Email,
            musteri.CreatedAt,
            musteri.IsActive,
            
            Adresler = (musteri.Adresler ?? new List<MusteriAdresi>()).Select(adres => new
            {
                adres.AddressId,
                adres.City,
                adres.District,
                adres.AddressText,
                adres.AddressType
            })
            .ToList(),

            IletisimBilgileri = (musteri.IletisimBilgileri ?? new List<MusteriIletisimBilgisi>()) 
            .Select(iletisim => new
            {
                iletisim.ContactId,
                iletisim.PhoneNumber,
                iletisim.ContactType
            })
            .ToList()
        };

        return Ok(musteriDetay);
    }

    [HttpPost]
    public ActionResult<Musteri> MusteriEkle(Musteri eklenecekMusteri)
    {
        var eklenenMusteri = _musteriServisi.MusteriEkle(eklenecekMusteri);
        return CreatedAtAction(nameof(IdIleMusteriGetir), new { musteriId = eklenenMusteri.CustomerId }, eklenenMusteri);
    }

    [HttpPut("{musteriId}")]
    public ActionResult<Musteri> MusteriGuncelle(int musteriId, Musteri guncellenecekMusteri)
    {
        var guncellenenMusteri = _musteriServisi.MusteriGuncelle(musteriId, guncellenecekMusteri);
        if (guncellenenMusteri == null) 
        { 
            return NotFound($"{musteriId} ID degerine sahip musteri bulunamadi.");
        }
        return Ok(guncellenenMusteri);
    }
}