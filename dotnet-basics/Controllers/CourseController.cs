using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class CourseController : Controller
{
    List<Course> kurslar = new List<Course>
    {
        new Course { Id = 1, Title = "Javascript Kursu", Image = "1.jpg", IsActive = true, IsHome = true },
        new Course { Id = 2, Title = "React Kursu", Image = "2.jpg", IsActive = true, IsHome = true },
        new Course { Id = 3, Title = "Angular Kursu", Image = "3.jpg", IsActive = true, IsHome = true },
        new Course { Id = 4, Title = "Vue.js Kursu", Image = "4.jpg", IsActive = true, IsHome = true },
        new Course { Id = 5, Title = "Node.js Kursu", Image = "5.jpg", IsActive = true, IsHome = false },
        new Course { Id = 6, Title = "ASP.NET Core Kursu", Image = "6.jpg", IsActive = true, IsHome = false },
    };

    // localhost:5158/home
    // localhost:5158/home/list => Burada bunu ekleriz.
    
    public ActionResult Index()
    {
        return View(kurslar);
    }

    public ActionResult List()
    {
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