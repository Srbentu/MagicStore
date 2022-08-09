using MagicStore.Repositories.Interfaces;
using MagicStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MagicStore.Controllers;

public class CartaController : Controller
{
    private readonly ICartaRepository _cartaRepository;
    public CartaController(ICartaRepository cartaRepository)
    {
        _cartaRepository = cartaRepository;
    }

    public IActionResult List()
    {
        //var cards = _cardRepository.Cards;
        //return View(cards);
        var cartaListViewModel = new CartaListViewModel();
        cartaListViewModel.Cartas = _cartaRepository.Cartas;
        cartaListViewModel.CategoriaAtual = "Categoria Atual";
        return View(cartaListViewModel);
    }
}