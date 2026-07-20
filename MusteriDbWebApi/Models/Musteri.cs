using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusteriDbWebApi.Models;

[Table("Musteriler")]
public class Musteri
{
    [Key]
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    public List<MusteriAdresi> Adresler { get; set; }
    public List<MusteriIletisimBilgisi> IletisimBilgileri { get; set; }
}
