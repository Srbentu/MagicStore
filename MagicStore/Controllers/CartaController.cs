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
            if (string.Equals("Batalha por Portal de Baldur", categoria, StringComparison.OrdinalIgnoreCase))
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Batalha por Portal de Baldur"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("Double Masters 2022", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Double Masters 2022"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("Ruas de Nova Capenna", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Ruas de Nova Capenna"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("A Guerra da Centelha", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("A Guerra da Centelha"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("Commander Anthology 2018", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Commander Anthology 2018"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("Commander 2019", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Commander 2019"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("Modern Horizons", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Modern Horizons"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("Kamigawa: Dinastia Neon", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Kamigawa: Dinastia Neon"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("Ultimate Masters", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Ultimate Masters"))
                    .OrderBy(c => c.Nome);
            }
            else if(string.Equals("Kaldheim Commander", categoria, StringComparison.OrdinalIgnoreCase)) 
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Kaldheim Commander"))
                    .OrderBy(c => c.Nome);
            }
            else
            {
                cartas = _cartaRepository.Cartas
                    .Where(c => c.Categoria.CategoriaNome.Equals("Innistrad: Voto Carmesim"))
                    .OrderBy(c => c.Nome);
            }

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