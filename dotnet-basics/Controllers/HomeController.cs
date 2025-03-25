using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController: Controller {

    // localhost:5158/ => Eğer direkt bu şekilde çağırırsak programın kendine belirlemiş olduğu değerler gelir o değerlerde Program.cs de belirlidir.
    // Burada "app.MapControllerRoute" içerisinde otomatik olarak gelicek ana değer "Home" ondan sonra gelicek değer ise "Index" diye belirlidir. 

    // localhost:5158/home => Eğer bu şekilde çağırırsak o zaman programın kendine tanımlı olan "Index" değerini getirir biz onun burada içerisini doldurduğumuz için buradaki Index() değeri gelir.
    public string Index() {
        return "Index";
    }


    // localhost:5158/home/about => Burada bunu ekleriz.

    public string About() {
        return "About";
    }

    // localhost:5158/home/contact => Burada bunu ekleriz.
    public string Contact() {
        return "About";
    }


}
