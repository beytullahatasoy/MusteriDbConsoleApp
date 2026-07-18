using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriDbConsoleApp.Models;

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