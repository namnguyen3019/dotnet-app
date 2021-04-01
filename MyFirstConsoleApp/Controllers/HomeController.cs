using System;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstConsoleApp.Controllers
{
    public class HomeController: Controller
    {
        public string Index()
        {
            return "WebGentle";
        }
    }
}
