
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller
{
    // localhost:3000/products
    public string Index()
    {
        return "Products/Index";
    }

    // localhost:3000/products/list
    public string List()
    {
        return "Products/List";
    }

    // localhost:3000/products/details
    public string Details()
    {
        return "Products/Details";
    }
}
