using MusteriDbConsoleApp.Services;

MusteriService musteriService = new MusteriService();

var musteriler = musteriService.MusterileriDetayliGetir();

foreach (var musteri in musteriler)
{
    Console.WriteLine("-------------------------------------");
    Console.WriteLine($"MusteriId: {musteri.CustomerId}");
    Console.WriteLine($"Ad Soyad: {musteri.FirstName} {musteri.LastName}");
    Console.WriteLine($"Email: {musteri.Email}");

    Console.WriteLine("Adres Bilgileri:");

    if (musteri.Adresler != null && musteri.Adresler.Count > 0)
    {
        foreach (var adres in musteri.Adresler)
        {
            Console.WriteLine($"Adres: {adres.City}, {adres.District}, {adres.AddressText}, {adres.AddressType}");
        }
    }
    else
    {
        Console.WriteLine("Adres bilgisi bulunamadý.");
    }

    Console.WriteLine("Ýletiþim Bilgileri:");

    if (musteri.IletisimBilgileri != null && musteri.IletisimBilgileri.Count > 0)
    {
        foreach (var iletisim in musteri.IletisimBilgileri)
        {
            Console.WriteLine($"Telefon: {iletisim.PhoneNumber}, Tür: {iletisim.ContactType}");
        }
    }
    else
    {
        Console.WriteLine("Ýletiþim bilgisi bulunamadý.");
    }
}

Console.WriteLine("Kapatmak için Enter'a bas...");
Console.ReadLine();