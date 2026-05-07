# 📝 TodoApp

![TodoApp Logo](todo_app_logo_1778169231137.png)

Modern, şık ve işlevsel bir yapılacaklar listesi uygulaması. ASP.NET Core MVC ve Entity Framework Core kullanılarak geliştirilmiştir.

## 🚀 Özellikler

- **Görev Yönetimi:** Yeni görevler ekleyin, başlık ve açıklama girin.
- **Durum Takibi:** Görevleri tamamlandı olarak işaretleyin veya geri alın.
- **Silme İşlemi:** Artık ihtiyacınız olmayan görevleri listenizden kaldırın.
- **Modern Arayüz:** Kullanıcı dostu, temiz ve duyarlı (responsive) tasarım.

## 🛠️ Teknoloji Yığını

- **Backend:** .NET 10.0 (ASP.NET Core MVC)
- **Veritabanı:** SQL Server (Entity Framework Core)
- **Frontend:** HTML5, CSS3, JavaScript
- **Tasarım:** Modern UI/UX yaklaşımları

## 📋 Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

### 1. Ön Koşullar
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) veya LocalDB
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (veya VS Code)

### 2. Veritabanı Yapılandırması
`appsettings.json` dosyasındaki bağlantı dizesini (ConnectionString) kendi SQL Server ayarlarınıza göre güncelleyin:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TodoAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### 3. Migration İşlemleri
Paket Yöneticisi Konsolu'nu (Package Manager Console) açın ve veritabanını oluşturmak için aşağıdaki komutu çalıştırın:

```bash
Update-Database
```

### 4. Uygulamayı Çalıştırma
Projeyi derlemek ve başlatmak için terminalde şu komutu kullanın:

```bash
dotnet run
```

Veya Visual Studio üzerinden **F5** tuşuna basarak başlatabilirsiniz.

## 📂 Proje Yapısı

- `Controllers/`: Uygulama mantığının yönetildiği yer (TodoController).
- `Models/`: Veri modelleri ve veritabanı bağlamı (AppDbContext, TodoItems).
- `Views/`: Kullanıcı arayüzü dosyaları (Razor Pages).
- `wwwroot/`: Statik dosyalar (CSS, JS, Resimler).

---

Bu proje, temel CRUD işlemlerini ve modern web geliştirme pratiklerini sergilemek amacıyla oluşturulmuştur.
