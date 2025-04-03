
using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;
public class CourseController : Controller
{
    // localhost:5158/home
    // localhost:5158/home/list => Burada bunu ekleriz.

    public ActionResult Index()
    {

        Course kurs1 = new Course
        {
            Title = "Javascript Kursu",
            Image = "1.jpg",
            IsActive = true,
            IsHome = true            
        };

        Course kurs2 = new Course
        {
            Title = "React Kursu",
            Image = "2.jpg",
            IsActive = true,
            IsHome = true            
        };

        Course kurs3 = new Course
        {
            Title = "Angular Kursu",
            Image = "3.jpg",
            IsActive = true,
            IsHome = false            
        };

        Course kurs4 = new Course
        {
            Title = "Angular Kursu",
            Image = "4.jpg",
            IsActive = true,
            IsHome = false            
        };

        Course kurs5 = new Course
        {
            Title = "Angular Kursu",
            Image = "4.jpg",
            IsActive = true,
            IsHome = false            
        };

        Course kurs6 = new Course
        {
            Title = "Angular Kursu",
            Image = "4.jpg",
            IsActive = true,
            IsHome = false            
        };

        // Burada kullanılan listeleme yapısı dışına başka bir yapıda kullanılabilir.

        // Course[] kurslar = [kurs1, kurs2, kurs3];

        // Burada aşşağıda olduğu gibi de listeleme biçimi kullanılabilir.
        List<Course> kurslar = new List<Course> {
            kurs1, kurs2, kurs3, kurs4, kurs5, kurs6
        };

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


        // Biz zaten buradaki değerleri model'de oluşturduğumuz için bu şekilde çağırabiliriz.
        Course kurs1 = new Course
        {
            Title = "Javascript Kursu",
            Image = "1.jpg",
            IsActive = true
            
        };

        Course kurs2 = new Course
        {
            Title = "React Kursu",
            Image = "2.jpg",
            IsActive = false
        };

        Course kurs3 = new Course
        {
            Title = "Angular Kursu",
            Image = "3.jpg",
            IsActive = true
        };

        // Burada kullanılan listeleme yapısı dışına başka bir yapıda kullanılabilir.

        // Course[] kurslar = [kurs1, kurs2, kurs3];

        // Burada aşşağıda olduğu gibi de listeleme biçimi kullanılabilir.
        List<Course> kurslar = new List<Course> {
            kurs1, kurs2, kurs3
        };

        return View(kurslar);
    }

    public ActionResult Details()
    {
        // // string kursAdi = "Django Kursu";
        // int kursSaati = 40;
        // // bool yayindami = true;
        // string[] kursAdlari = ["Javascript Kursu", "React Kursu"];
        // ViewData["kursSaati"] = kursSaati;

        // return View(kursAdlari);

        Course kurs1 = new Course();
        kurs1.Title = "Django Kursu";
        kurs1.Image = "1.jpg";

        return View(kurs1);
    }
}