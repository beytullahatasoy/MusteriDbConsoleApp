using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriDbConsoleApp.Models;

[Table("MusteriAdresleri")]
public class MusteriAdresi
{
    [Key]
    public int AddressId { get; set; }
    public int CustomerId { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string AddressText { get; set; }
    public string AddressType { get; set; }

    public Musteri Musteri { get; set; }
}