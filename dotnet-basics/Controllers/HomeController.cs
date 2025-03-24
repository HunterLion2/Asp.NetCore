using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController: Controller {

    // localhost:5158/home
    // localhost:5158/home/about => Burada bunu ekleriz.

    public string About() {
        return "About";
    }

}
