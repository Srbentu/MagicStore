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

    public IActionResult Details(int cartaId)
    {
        var carta = _cartaRepository.Cartas.FirstOrDefault(c => c.CartaId == cartaId);
        return View(carta);
    }

    public ViewResult Search(string searchString)
    {
        IEnumerable<Carta> cartas;
        string categoriaAtual = string.Empty;

        if (string.IsNullOrEmpty(searchString))
        {
            cartas = _cartaRepository.Cartas.OrderBy(c => c.CartaId);
            categoriaAtual = "Todas as Cartas";
        }
        else
        {
            cartas = _cartaRepository.Cartas
                .Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));
            if (cartas.Any())
            {
                categoriaAtual = "Cartas";
            }
            else
            {
                categoriaAtual = "Nenhuma Carta foi Encontrada";
            }
        }

        return View("~/Views/Carta/List.cshtml", new CartaListViewModel
        {
            Cartas = cartas,
            CategoriaAtual = categoriaAtual
        });
    }
}