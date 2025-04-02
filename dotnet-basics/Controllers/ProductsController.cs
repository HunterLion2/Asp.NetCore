
using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller
{
    // localhost:3000/products
    public ActionResult Index()
    {
        string[] kurslar = {"Javasctipt", "React Kursu"};
        return View(kurslar);
    }

    // localhost:3000/products/list
    public ActionResult List() {

    List<Product> urunler = new List<Product> {
            
        new Product() {
            ÜrünBaslık = "Iphone 15",ÜrünFiyat = 80000,ÜrünResim = "i1.png", ÜrünAcıklama = "Güzel Telefon", ÜrünSatıstamı = true
        },

        new Product() {
            ÜrünBaslık = "Iphone 16",ÜrünFiyat = 80000,ÜrünResim = "i2.png", ÜrünAcıklama = "Güzel Telefon", ÜrünSatıstamı = true
        },

        new Product() {
            ÜrünBaslık = "Iphone 17",ÜrünFiyat = 80000,ÜrünResim = "i3.png", ÜrünAcıklama = "Güzel Telefon", ÜrünSatıstamı = false
        }
    
    };

        return View(urunler);
    }


    // localhost:3000/products/details
    public ActionResult Details()
    {

        Product urun1 = new Product();

        urun1.ÜrünBaslık = "Samsung S24 Ultra";
        urun1.ÜrünAcıklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah";
        urun1.ÜrünFiyat = 7000;
        urun1.ÜrünResim = "samsung-s24.jpg";
        urun1.ÜrünSatıstamı = false;
        urun1.StokAdedi = 100;

        return View(urun1); // Burada bu şekilde View'in içerisine bu değeri yazdığımız zaman o zaman bu değeri "Details" fonksiyonu beklemeye başlar.
    }
}
