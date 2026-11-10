# Ninja Cat Game | C# Nesne Yönelimli Programlama Projesi

C# ve Windows Forms kullanılarak geliştirilmiş, nesne yönelimli programlama prensiplerini uygulayan 2D masaüstü oyun projesidir.

Proje, Sakarya Üniversitesi Bilgi Sistemleri Mühendisliği bölümü Nesneye Dayalı Programlama dersi kapsamında 2021-2022 Bahar döneminde geliştirilmiştir.

## Proje Hakkında

Ninja Cat, oyuncunun bir kediyi kontrol ederek oyun alanındaki nesneleri topladığı, belirli görevleri tamamlayarak skor kazandığı bir masaüstü oyunudur.

Uygulama, kullanıcı arayüzü ile oyun mantığını ayrı projelerde ele alacak şekilde tasarlanmıştır. Oyun nesneleri ve temel oyun davranışları ayrı bir sınıf kütüphanesinde modellenmiştir.

## Özellikler

- Oyuncu bilgilerini kaydetme
- Kedi karakterini klavye ile kontrol etme
- Oyun alanında farklı nesnelerin rastgele oluşturulması
- Nesnelerle çarpışma ve toplama mekanizması
- Zamanlayıcı tabanlı oyun akışı
- Skor hesaplama ve kayıt işlemleri
- En yüksek skorların listelenmesi
- Oyunu başlatma ve duraklatma

## Kullanılan Teknolojiler

- **Programlama dili:** C#
- **Masaüstü arayüzü:** Windows Forms
- **Platform:** .NET Framework 4.7.2
- **Veritabanı:** Microsoft SQL Server
- **Veri erişimi:** ADO.NET
- **Arayüz bileşenleri:** Guna UI2

## Nesne Yönelimli Programlama Yaklaşımı

Projede nesne yönelimli programlamanın temel kavramları kullanılmıştır.

| Kavram | Projedeki uygulaması |
|---|---|
| Encapsulation | Sınıf üyeleri ve erişim belirleyicileri |
| Inheritance | `Cisim` sınıfından türetilen oyun nesneleri |
| Abstraction | Soyut `Cisim` sınıfı |
| Interface | `IHareketEden` ve `IOyun` |
| Polymorphism | Ortak hareket davranışlarının nesne sınıfları üzerinden kullanılması |
| Enum | `Yon` hareket yönleri |

## Proje Mimarisi

Çözüm iki ayrı projeden oluşur:

- **NDPPROJE:** Windows Forms kullanıcı arayüzü, giriş, oyun ve skor ekranları.
- **NDPPROJELIBRARY:** Oyun nesneleri, soyut sınıflar, arayüzler ve oyun mekanikleri.

## Kurulum

Gerekli araçlar:

- Windows işletim sistemi
- Visual Studio
- .NET Framework 4.7.2 Developer Pack
- Microsoft SQL Server

Projeyi çalıştırmak için:

1. `NDPPROJE.sln` dosyasını Visual Studio ile açın.
2. SQL Server üzerinde `OYUN` veritabanını oluşturun.
3. Gerekli `T_OYUN` tablosunu ve alanlarını yapılandırın.
4. `App.config` içerisindeki bağlantı ayarlarını yerel SQL Server ortamınıza göre düzenleyin.
5. NuGet paketlerini geri yükleyin.
6. `NDPPROJE` projesini başlangıç projesi olarak seçip çalıştırın.

> Not: Veritabanı şeması ve kurulum adımları, dağıtıma hazır hâle getirilmeden önce ayrıca doğrulanmalıdır.

## Geliştirilen Yetkinlikler

- C# ile nesne yönelimli programlama
- Windows Forms masaüstü uygulaması geliştirme
- Sınıf, arayüz ve soyut sınıf tasarımı
- Oyun nesnelerinin hareket ve çarpışma yönetimi
- SQL Server ile veri saklama
- ADO.NET ile veritabanı işlemleri
- Zamanlayıcı ve olay tabanlı programlama

## Proje Durumu

Bu proje eğitim kapsamında geliştirilmiş bir çalışmadır. Kod yapısı; veritabanı erişiminin ayrıştırılması, parametreli SQL sorgularının yaygınlaştırılması, hata yönetimi ve kaynak yönetimi açısından geliştirilmeye açıktır.
