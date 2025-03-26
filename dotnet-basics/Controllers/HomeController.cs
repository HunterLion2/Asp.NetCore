using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController: Controller {

    // localhost:5158/ => Eğer direkt bu şekilde çağırırsak programın kendine belirlemiş olduğu değerler gelir o değerlerde Program.cs de belirlidir.
    // Burada "app.MapControllerRoute" içerisinde otomatik olarak gelicek ana değer "Home" ondan sonra gelicek değer ise "Index" diye belirlidir. 

    // localhost:5158/home => Eğer bu şekilde çağırırsak o zaman programın kendine tanımlı olan "Index" değerini getirir biz onun burada içerisini doldurduğumuz için buradaki Index() değeri gelir.

    // Burada ActionResult değeri ile return ettiğimiz değerin bir dosya olduğunu anlar.

    public ActionResult Index() {
        return View(); // View/Home/Index.cshtml
         
        // Burada ki View değeri klasörlerimizdeki Views değeridir.
    }

    // localhost:5158/home/about => Burada bunu ekleriz.

    public ActionResult About() {
        return View(); // View/Home/About.cshtml
    }

    // localhost:5158/home/contact => Burada bunu ekleriz.
    public ActionResult Contact() {
        return View(); // View/Home/Contact.cshtml
    }


}
