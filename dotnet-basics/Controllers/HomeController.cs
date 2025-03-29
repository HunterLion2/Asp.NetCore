using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController: Controller {

    // localhost:5158/ => Eğer direkt bu şekilde çağırırsak programın kendine belirlemiş olduğu değerler gelir o değerlerde Program.cs de belirlidir.
    // Burada "app.MapControllerRoute" içerisinde otomatik olarak gelicek ana değer "Home" ondan sonra gelicek değer ise "Index" diye belirlidir. 

    // localhost:5158/home => Eğer bu şekilde çağırırsak o zaman programın kendine tanımlı olan "Index" değerini getirir biz onun burada içerisini doldurduğumuz için buradaki Index() değeri gelir.

    // Burada ActionResult değeri ile return ettiğimiz değerin bir dosya olduğunu anlar.

    public ActionResult Index() {
        
         
        // Burada ki View değeri klasörlerimizdeki Views değeridir.


        int sayi1 = 10;
        int sayi2 = 20;

        sayi1 = 30;
        sayi2 = 40;

        int toplam = sayi1 + sayi2;

        ViewData["Toplam"] = toplam; // Burada ViewData'nın içerisine girilen değer bir (key) değeridir. Bu değeri bu Controller değerinin bağlandığı bir html de yine ViewData diyip içerisine key değerini girerek çağırabiliriz.

        return View(); // View/Home/Index.cshtml


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
