using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    // Action pour afficher index.html
    public IActionResult Index()
    {
        return File("~/wwwroot/index.html", "text/html");
    }
}
