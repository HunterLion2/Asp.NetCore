
using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;
public class CourseController : Controller
{


    List<Course> kurslar = [
        new Course {Id = 1, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 2, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 3, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 4, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 5, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true},
        new Course {Id = 6, Title = "Javascript Kursu",Image = "1.jpg",IsActive = true,IsHome = true}
    ];

    // localhost:5158/home
    // localhost:5158/home/list => Burada bunu ekleriz.
    
    public ActionResult Index()
    {
        return View(kurslar);
    }

    public ActionResult List()
    {
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