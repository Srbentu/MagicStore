using MagicStore.Models;
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

    public IActionResult List(string categoria)
    {
        IEnumerable<Carta> cartas;
        string categoriaAtual = string.Empty;

        if (string.IsNullOrEmpty(categoria))
        {
            cartas = _cartaRepository.Cartas.OrderBy(l => l.CartaId);
            categoriaAtual = "Todas as cartas";
        }
        else
        {
            cartas = _cartaRepository.Cartas
                .Where(c => c.Categoria.CategoriaNome.Equals(categoria))
                .OrderBy(l => l.Nome);
            

            categoriaAtual = categoria;
        }

        var cartaListViewModel = new CartaListViewModel
        {
            Cartas = cartas,
            CategoriaAtual = categoriaAtual
        };
        return View(cartaListViewModel);
    }
}