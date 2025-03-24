
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;
    public class CourseController: Controller
    {
        

        // localhost:5158/home
        // localhost:5158/home/list => Burada bunu ekleriz.

        public string List() {
            return "List";
        }

    }