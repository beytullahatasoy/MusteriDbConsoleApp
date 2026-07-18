using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using MusteriDbConsoleApp.Models;

namespace MusteriDbConsoleApp.Data;
public class MusteriDbContext : DbContext
{
    public DbSet<Musteri> Musteriler { get; set; }
    public DbSet<MusteriAdresi> MusteriAdresleri { get; set; }
    public DbSet<MusteriIletisimBilgisi> MusteriIletisimBilgileri { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=MusteriDB;Trusted_Connection=True;TrustServerCertificate=True;"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MusteriAdresi>()
            .HasOne(adres => adres.Musteri)
            .WithMany(musteri => musteri.Adresler)
            .HasForeignKey(adres => adres.CustomerId);

        modelBuilder.Entity<MusteriIletisimBilgisi>()
            .HasOne(iletisim => iletisim.Musteri)
            .WithMany(musteri => musteri.IletisimBilgileri)
            .HasForeignKey(iletisim => iletisim.CustomerId);
    }
}