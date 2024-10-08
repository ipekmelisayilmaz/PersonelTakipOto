# Personel Takip Otomasyon Sistemi ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)


**Personel Takip Otomasyon Sistemi**, 
personel yönetimi süreçlerini kolaylaştırmak için geliştirilmiş bir yazılım çözümüdür.
Bu proje, **C# dili**  , **LINQ to SQL** ve **Katmanlı Mimari** kullanılarak inşa edilmiştir. 
Uygulama, personel ekleme, güncelleme, silme, listeleme izin yönetimi,departman işemleri pozisyon işlemleri ve maaş işlemleri gibi özellikleri içermektedir. 
Ayrıca, yönetici paneli sayesinde kullanıcılar, yetkilendirilmiş işlemleri gerçekleştirebilir.

## Proje Özellikleri

- **Katmanlı Mimari:** Uygulama, üç ana katmandan oluşur:
  - **Presentation (UI) Katmanı:** Kullanıcı arayüzünü yönetir.
  - **Business Logic (BLL) Katmanı:** İş mantığını içerir.
  - **Data Access (DAL) Katmanı:** Veri tabanı işlemleri ve veri erişim katmanıdır.
 

- **LINQ to SQL:** Veritabanı işlemleri LINQ to SQL kullanılarak gerçekleştirilmiştir.
- **Yönetici Paneli:** Yöneticiler, özel bir panel aracılığıyla tüm personel bilgilerini yönetebilir.
- **Tetikleyiciler (Triggers):** Veritabanındaki belirli işlemlerin ardından otomatik olarak çalıştırılan SQL tetikleyicileri oluşturulmuştur.
- **Yetkilendirme:** Kullanıcı adı ve şifre ile giriş yaparak yetkilendirilmiş işlemleri gerçekleştirme özelliği sunulmuştur.
 
### Gereksinimler

- **Visual Studio 2022** veya daha yeni bir sürüm.
- **SQL Server** veya uyumlu bir veritabanı yönetim sistemi.

## Kurulum ve Çalıştırma

Aşağıdaki komutu kullanarak projeyi yerel makinenize klonlayın:

git clone https://github.com/ipekmelisayilmaz/PersonelTakipOto.git

Veritabanını Oluşturun: SQL Server üzerinde bir veritabanı oluşturun  :  ( script) dosyasını kullanarak SQL sorgularını çalıştırın: (SQLQuery1.sql, SQLQuery2.sql , SQLQuery3.sql) dosyalarını kullanarak trigger oluşturun

App.config dosyasında yer alan connection string'i, kendi veritabanı ayarlarınıza göre güncelleyin

Visual Studio'da PersonelTakipOto.sln çözüm dosyasını açın ve projeyi çalıştırın

## Kullanıcı Giriş Bilgileri

Proje içerisindeki yönetici ve personel girişlerini test etmek için aşağıdaki kullanıcı bilgilerini kullanabilirsiniz;


### Admin Girişi
- **Kullanıcı Numarası:** 1
- **Şifre:** 1

### Personel Girişi
- **Kullanıcı Numarası:** 3
- **Şifre:** 3

















































