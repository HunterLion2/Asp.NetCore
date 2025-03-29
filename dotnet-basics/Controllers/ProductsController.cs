
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller
{
    // localhost:3000/products
    public ActionResult Index()
    {
        return View();
    }

    // localhost:3000/products/list
    public ActionResult List()
    {
        return View();
    }

    // localhost:3000/products/details
    public ActionResult Details()
    {
        // Samsung S24 Ultra
        // Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah
        // 70.000
        // samsung-s24.jpg

        string urunBaslik = "Samsung S24 Ultra";
        string urunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah";
        double urunFiyat = 70000;
        string urunResim = "samsung-s24.jpg";
        bool urunSatistami = false; // true

        ViewData["urunBaslik"] = urunBaslik;
        ViewData["urunAciklama"] = urunAciklama;
        ViewData["urunFiyat"] = urunFiyat;
        ViewData["urunResim"] = urunResim;
        ViewData["urunSatistami"] = urunSatistami;

        return View();
    }
}
