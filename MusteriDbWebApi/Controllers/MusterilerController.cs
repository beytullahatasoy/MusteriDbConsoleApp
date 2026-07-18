using Microsoft.AspNetCore.Mvc;
using MusteriDbWebApi.Services;
using MusteriDbWebApi.Models;

namespace MusteriDbWebApi.Controllers;

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
    public ActionResult<List<Musteri>> MusteriGetir()
    {
        var musteriler = _musteriServisi.MusteriGetir();

        return Ok(musteriler);
    }
}
