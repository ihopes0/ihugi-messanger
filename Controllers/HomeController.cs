using Microsoft.AspNetCore.Mvc;

namespace ihugi_messanger.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}