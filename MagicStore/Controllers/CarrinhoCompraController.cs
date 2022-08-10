using MagicStore.Models;
using MagicStore.Repositories.Interfaces;
using MagicStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MagicStore.Controllers;

public class CarrinhoCompraController : Controller
{
    private readonly ICartaRepository _cartaRepository;
    private readonly CarrinhoCompra _carrinhoCompra;

    public CarrinhoCompraController(ICartaRepository cartaRepository, CarrinhoCompra carrinhoCompra)
    {
        _cartaRepository = cartaRepository;
        _carrinhoCompra = carrinhoCompra;
    }
    
    // GET
    public IActionResult Index()
    {
        var itens = _carrinhoCompra.GetCarrinhoCompraItens();
        _carrinhoCompra.CarrinhoCompraItems = itens;

        var carrinhoCompraVM = new CarrinhoCompraViewModel
        {
            CarrinhoCompra = _carrinhoCompra,
            CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
        };
        
        return View(carrinhoCompraVM);
    }

    public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int cartaId)
    {
        var CartaSelecionada = _cartaRepository.Cartas.FirstOrDefault(p => p.CartaId == cartaId);
        if (CartaSelecionada != null)
        {
            _carrinhoCompra.AdicionarAoCarrinho(CartaSelecionada);
        }

        return RedirectToAction("Index");
    }
    
    public RedirectToActionResult RemoverItemDoCarrinhoCompra(int cartaId)
    {
        var CartaSelecionada = _cartaRepository.Cartas.FirstOrDefault(p => p.CartaId == cartaId);
        if (CartaSelecionada != null)
        {
            _carrinhoCompra.RemoverDoCarrinho(CartaSelecionada);
        }

        return RedirectToAction("Index");
    }
}