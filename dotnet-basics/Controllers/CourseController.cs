using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class CourseController : Controller
{
<<<<<<< HEAD
    List<Course> kurslar = new List<Course>
    {
        new Course { Id = 1, Title = "Javascript Kursu", Image = "1.jpg", IsActive = true, IsHome = true },
        new Course { Id = 2, Title = "React Kursu", Image = "2.jpg", IsActive = true, IsHome = true },
        new Course { Id = 3, Title = "Angular Kursu", Image = "3.jpg", IsActive = true, IsHome = true },
        new Course { Id = 4, Title = "Vue.js Kursu", Image = "4.jpg", IsActive = true, IsHome = true },
        new Course { Id = 5, Title = "Node.js Kursu", Image = "5.jpg", IsActive = true, IsHome = false },
        new Course { Id = 6, Title = "ASP.NET Core Kursu", Image = "6.jpg", IsActive = true, IsHome = false },
    };
=======


    List<Course> kurslar = [
        new Course {Id = 1, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 2, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 3, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 4, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 5, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 6, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true}
    ];
>>>>>>> 182b25f306065cefe49ca8504cb424501c403bde

    // localhost:5158/home
    // localhost:5158/home/list => Burada bunu ekleriz.
    
    public ActionResult Index()
    {
        return View(kurslar);
    }

    public ActionResult List()
    {
<<<<<<< HEAD
=======
        // string kursAdi1 = "Javascript Kursu";
        // string kursAdi2 = "React Kursu";

        // string kursAciklama1 = "Javascript Kurs Açıklaması";
        // string kursAciklama2 = "React Kurs Açıklaması";

        // string[] kursAdlari = ["Javascript Kursu", "React Kursu"];
        // string[] kursAciklamalari = ["Javascript Kurs Açıklaması", "React Kurs Açıklaması"];
        // string[] kursResimleri = ["1.jpg", "2.jpg"];

        // ViewData["kursAdi1"] = kursAdlari[0]; // Javascript Kursu
        // ViewData["kursAdi2"] = kursAdlari[1]; // React Kursu

        // ViewData["kursAciklama1"] = kursAciklamalari[0]; // Javascript Kurs Açıklaması
        // ViewData["kursAciklama2"] = kursAciklamalari[1]; // React Kurs Açıklaması

        // ViewData["kursResim1"] = kursResimleri[0]; // 1.jpg
        // ViewData["kursResim2"] = kursResimleri[1]; // 2.jpg

        // ViewData["kursAdlari"] = kursAdlari;
        // ViewData["kursAciklamalari"] = kursAciklamalari;
        // ViewData["kursResimleri"] = kursResimleri;
        // @(((string[])ViewData["kursAdlari"])[0])

        // Burada kullanılan listeleme yapısı dışına başka bir yapıda kullanılabilir.

        // Course[] kurslar = [kurs1, kurs2, kurs3];


>>>>>>> 182b25f306065cefe49ca8504cb424501c403bde
        return View(kurslar);
    }

    public ActionResult Details(int id)
    {
        // // string kursAdi = "Django Kursu";
        // int kursSaati = 40;
        // // bool yayindami = true;
        // string[] kursAdlari = ["Javascript Kursu", "React Kursu"];
        // ViewData["kursSaati"] = kursSaati;

        // return View(kursAdlari);

        Course? kurs = kurslar.Where(a => a.Id == id).FirstOrDefault();

        // Burada Where değeri bir döndü gibidir yukarıdaki kurslar’ın içerisindeki tüm değerlerin adını “a” olarak ayarladık
        // sonrada a’nın Id değeri dışarıdan gelene ilk eşit olanı getir dedik buranın türkçe karşılığı o dur.

        return View(kurs);
    }
}