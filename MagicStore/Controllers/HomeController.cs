using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MagicStore.Models;
using MagicStore.Repositories.Interfaces;
using MagicStore.ViewModels;

namespace MagicStore.Controllers;

public class HomeController : Controller
{
    private readonly ICartaRepository _cartaRepository;

    public HomeController(ICartaRepository cartaRepository)
    {
        _cartaRepository = cartaRepository;
    }

    public IActionResult Index()
    {
        var homeViewModel = new HomeViewModel
        {
            CartasPreferidas = _cartaRepository.CartasPreferidas
        };
        
        return View(homeViewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}