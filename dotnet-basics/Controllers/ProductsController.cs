
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
        return View();
    }
}
