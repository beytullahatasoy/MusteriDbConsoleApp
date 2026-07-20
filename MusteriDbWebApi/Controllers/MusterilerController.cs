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
}
