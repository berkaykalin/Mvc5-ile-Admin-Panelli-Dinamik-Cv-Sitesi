# Mvc5-ile-Admin-Panelli-Dinamik-Cv-Sitesi

Bu proje, **Mvc5 ile Admin Panelli Dinamik Cv Sitesi** olarak adlandırılmaktadır. Proje, kullanıcıların kendileri hakkındaki kişisel bilgileri yönetebileceği ve diğer insanlara sunabileceği bir web uygulamasıdır. 

## Bu Projeyi Geliştirirken Kullandığım Teknolojiler ve Modeller

- ASP.NET MVC5
- Db First
- Entity Framework
- Repository Design Pattern
- MSSQL Server
- HTML
- CSS
- Bootstrap
- jQuery
- DataTable
- Authentication

## Kurulum

Bu projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin.

### Gereksinimler

- MSSQL Server
- Visual Studio

### Adımlar

1. **Depoyu klonlayın:**
    ```bash
    git clone https://github.com/berkaykalin/Mvc5-ile-Admin-Panelli-Dinamik-Cv-Sitesi.git
    cd Mvc5-ile-Admin-Panelli-Dinamik-Cv-Sitesi
    ```

2. **Bağımlılıkları yükleyin:**
    ```bash
    dotnet restore
    ```

3. **Veritabanı ayarlarını yapılandırın:**
    - `appsettings.json` dosyasını açın ve veritabanı bağlantı ayarlarını güncelleyin:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=.;Database=ProjeDb;Trusted_Connection=True;"
      }
    }
    ```

4. **Veritabanını güncelleyin:**
    ```bash
    dotnet ef database update
    ```

5. **Uygulamayı çalıştırın:**
    ```bash
    dotnet run
    ```

## Kullanım

Uygulamayı tarayıcınızda açarak kullanabilirsiniz. Admin paneline erişmek için `/admin` yolunu kullanın. Varsayılan admin hesabı oluşturduysanız, onunla giriş yaparak yönetim paneline erişebilirsiniz.

## İletişim

Sorularınız veya geri bildirimleriniz için lütfen benimle iletişime geçin:

- **E-posta:** berkay.kalinn@gmail.com

## Ekran Görüntüleri

![Ana Sayfa](https://github.com/berkaykalin/Mvc5-ile-Admin-Panelli-Dinamik-Cv-Sitesi/raw/main/WebSitesiResimler/AnaSayfa1.png)
![Ana Sayfa](https://github.com/berkaykalin/Mvc5-ile-Admin-Panelli-Dinamik-Cv-Sitesi/raw/main/WebSitesiResimler/AnaSayfa2.png)
![Login Paneli](https://github.com/berkaykalin/Mvc5-ile-Admin-Panelli-Dinamik-Cv-Sitesi/raw/main/WebSitesiResimler/Login.png)
![Admin Paneli](https://github.com/berkaykalin/Mvc5-ile-Admin-Panelli-Dinamik-Cv-Sitesi/raw/main/WebSitesiResimler/Admin1.png)
![Admin Paneli](https://github.com/berkaykalin/Mvc5-ile-Admin-Panelli-Dinamik-Cv-Sitesi/raw/main/WebSitesiResimler/Admin2.png)

---

