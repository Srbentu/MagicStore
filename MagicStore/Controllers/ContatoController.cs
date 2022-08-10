using Microsoft.AspNetCore.Mvc;

namespace MagicStore.Controllers;

public class ContatoController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}