# MusteriDbConsoleApp

## 1. Projenin Kısa Açıklaması
Bu proje, C# Console Application tabanlı, müşteri verilerini yönetmek için geliştirilmiş bir veri erişim uygulamasıdır. ADO.NET ve Entity Framework Core teknolojilerinin aynı projede nasıl kullanılabileceğini ve veritabanı işlemlerinin nasıl gerçekleştirileceğini göstermektedir.

## 2. Projenin Amacı
Uygulamanın temel amacı, Microsoft SQL Server üzerinde oluşturulan ilişkisel bir veritabanı ile C# uygulamasının etkileşimini, hem geleneksel ADO.NET yöntemleriyle hem de modern bir ORM aracı olan Entity Framework Core ile uygulamalı olarak öğrenmek ve pekiştirmektir.

## 3. Kullanılan Teknolojiler
- C#
- .NET 9
- Microsoft SQL Server
- ADO.NET
- Entity Framework Core
- LINQ

## 4. Öğrenilen ve Uygulanan Konular
Proje geliştirme sürecinde aşağıdaki kavramlar ve teknolojiler uygulanmıştır:
- **ADO.NET:**
  - `SqlConnection`, `SqlCommand`, `SqlDataReader` kullanımları.
  - Parametreli sorgular ile SQL Injection önleme.
  - Temel CRUD (Create, Read, Update, Delete) işlemleri.
  - Tablolar arası JOIN işlemleri.
- **Entity Framework Core:**
  - Model class'ları oluşturma.
  - `DbContext` ve `DbSet` tanımlamaları.
  - Veri getirme, filtreleme ve ekleme (`ToList`, `FirstOrDefault`, `Add`, `Remove`).
  - Veritabanı değişikliklerini kaydetme (`SaveChanges`).
  - İlişkili verileri çekme (`Include` ile Eager Loading).
- Müşteri veritabanı işlemlerinin modüler bir yapı sağlamak adına `Program.cs` yerine `MusteriService` isimli ayrı bir servis sınıfı üzerinden yönetilmesi.

## 5. Proje Klasör Yapısı
Proje, temiz ve anlaşılır bir yapıya sahip olacak şekilde aşağıdaki gibi organize edilmiştir:

```text
MusteriDbConsoleApp
├── Data
│   └── MusteriDbContext.cs        # EF Core veritabanı bağlam sınıfı
├── Models
│   ├── Musteri.cs                 # Müşteri varlık modeli
│   ├── MusteriAdresi.cs           # Müşteri adres varlık modeli
│   └── MusteriIletisimBilgisi.cs  # Müşteri iletişim varlık modeli
├── Services
│   └── MusteriService.cs          # Veritabanı işlemlerini yürüten servis
├── Examples ADO.NET               # ADO.NET uygulamalı kod örnekleri
├── Examples EF Core               # EF Core uygulamalı kod örnekleri
└── Program.cs                     # Uygulamanın giriş noktası
```

## 6. Veritabanı Yapısı
Uygulama, `MusteriDB` adlı veritabanını kullanır ve aşağıdaki tablolar arası ilişkileri barındırır:
- **Musteriler:** Temel müşteri bilgilerini tutar.
- **MusteriAdresleri:** Müşterilerin adres bilgilerini içerir (Musteriler tablosuyla ilişkili).
- **MusteriIletisimBilgileri:** Müşterilere ait iletişim detaylarını barındırır (Musteriler tablosuyla ilişkili).
Tablolar arasında uygun Primary Key (Birincil Anahtar) ve Foreign Key (Yabancı Anahtar) ilişkileri mevcuttur.

## 7. Kurulum Gereksinimleri
Projeyi kendi ortamınızda çalıştırabilmek için aşağıdaki şartların sağlanması gerekmektedir:
- Sisteminizde **Microsoft SQL Server** kurulu ve çalışır durumda olmalıdır.
- SQL Server üzerinde `MusteriDB` isimli veritabanı ve ilgili tabloların önceden oluşturulmuş olması gereklidir (Otomatik migration işlemi uygulanmamaktadır).
- `Data/MusteriDbContext.cs` veya ilgili servis sınıfları içerisindeki veritabanı bağlantı (Connection String) bilgilerinin kendi SQL Server ayarlarınıza uygun şekilde kontrol edilmesi ve gerekirse düzenlenmesi gerekmektedir.
- Projede kullanılan NuGet paketlerinin başarıyla yüklenmesi (Restore) gerekmektedir.
- Projenin `MusteriDbConsoleApp.sln` dosyası üzerinden Visual Studio (veya uygun bir IDE) ile açılması önerilir.

## 8. Projeyi Çalıştırma Adımları
1. Projeyi Visual Studio ile açın.
2. Solution Explorer üzerinden sağ tıklayıp "Restore NuGet Packages" işlemini gerçekleştirin veya projeyi derleyin (Build).
3. Veritabanı bağlantı dizesini kontrol edin ve kendi ortamınıza uyumlu olduğundan emin olun.
4. Başlangıç projesi olarak `MusteriDbConsoleApp` seçili olduğundan emin olun ve **Start (F5)** veya **Start Without Debugging (Ctrl+F5)** ile projeyi çalıştırın.

## 9. Kullanılan NuGet Paketleri
Proje kapsamında Entity Framework Core ve SQL Server bağlantısı için aşağıdaki NuGet paketleri kullanılmıştır:
- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.Data.SqlClient`

## 10. Examples Klasörlerinin Açıklaması
Proje içerisinde yer alan `Examples ADO.NET` ve `Examples EF Core` isimli klasörler, öğrenme sürecinde oluşturulan ve çeşitli veritabanı işlemlerinin nasıl yapıldığını gösteren `.txt` uzantılı uygulamalı kod örneklerini içerir. Bu örnekler referans amaçlıdır ve teorik bilgilerin pratiğe döküldüğü dosyaları barındırır.

## 11. Projenin Mevcut Durumu
Bu proje, tamamlanmış büyük bir kurumsal sistemden ziyade; ADO.NET ve Entity Framework Core teknolojilerinin veri erişimindeki farklılıklarını, temel C# ve SQL Server entegrasyonunu kavramak amacıyla oluşturulmuş profesyonel bir öğrenme ve uygulama projesidir.

## 12. Geliştirilebilecek Özellikler
Projeyi daha ileriye taşımak için yapılabilecek potansiyel geliştirmeler:
- Repository ve Unit of Work gibi tasarım desenlerinin (Design Patterns) uygulanması.
- Konsol arayüzünün kullanıcı etkileşimli hale getirilmesi (Kullanıcıdan menü aracılığıyla girdi alınması).
- Hata yönetimi (Exception Handling) mekanizmalarının ve Loglama (NLog, Serilog) altyapısının eklenmesi.
- Code-First yaklaşımı ile otomatik Migration işlemlerinin devreye alınması (Veritabanı oluşturma sürecinin projeye entegre edilmesi).
- Asenkron metotların (`ToListAsync`, `SaveChangesAsync` vb.) kullanımı ile performans iyileştirmeleri yapılması.
