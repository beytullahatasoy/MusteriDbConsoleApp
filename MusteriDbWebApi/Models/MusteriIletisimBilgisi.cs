using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusteriDbWebApi.Models;

[Table("MusteriIletisimBilgileri")]
public class MusteriIletisimBilgisi
{
    [Key]
    public int ContactId { get; set; }
    public int CustomerId { get; set; }
    public string PhoneNumber { get; set; }
    public string ContactType { get; set; }

    public Musteri Musteri { get; set; }
}