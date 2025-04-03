
using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller
{
    // localhost:3000/products


    List<Product> producturunler = new List<Product> {

            new Product() {Id = 1,Image = "i1.png", Title = "Iphone 15", Description = "Güzel Telefon", IsOnSale = true},
            new Product() {Id = 2,Image = "i2.png", Title = "Iphone 16", Description = "Güzel Telefon", IsOnSale = true},
            new Product() {Id = 3,Image = "i3.png", Title = "Iphone 17", Description = "Güzel Telefon", IsOnSale = false},
            new Product() {Id = 4,Image = "i4.png", Title = "Iphone 18", Description = "Güzel Telefon", IsOnSale = true},
    };

    public ActionResult Index()
    {
        return View(producturunler);
    }

    // localhost:3000/products/list
    public ActionResult List() {
        return View(producturunler);
    }


    // localhost:3000/products/details
    public ActionResult Details(int id)
    {

        // Product urun1 = new Product();

        // urun1.ÜrünBaslık = "Samsung S24 Ultra";
        // urun1.ÜrünAcıklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah";
        // urun1.ÜrünFiyat = 7000;
        // urun1.ÜrünResim = "samsung-s24.jpg";
        // urun1.ÜrünSatıstamı = false;
        // urun1.StokAdedi = 100;

        Product? product = producturunler.Where(kurs => kurs.Id == id).FirstOrDefault();

        return View(product); // Burada bu şekilde View'in içerisine bu değeri yazdığımız zaman o zaman bu değeri "Details" fonksiyonu beklemeye başlar.
    }
}
