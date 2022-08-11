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

    public IActionResult AdicionarItemNoCarrinhoCompra(int cartaId)
    {
        var cartaSelecionada = _cartaRepository.Cartas.FirstOrDefault(p => p.CartaId == cartaId);
        if (cartaSelecionada != null)
        {
            _carrinhoCompra.AdicionarAoCarrinho(cartaSelecionada);
        }

        return RedirectToAction("Index");
    }
    
    public IActionResult RemoverItemDoCarrinhoCompra(int cartaId)
    {
        var cartaSelecionada = _cartaRepository.Cartas.FirstOrDefault(p => p.CartaId == cartaId);
        if (cartaSelecionada != null)
        {
            _carrinhoCompra.RemoverDoCarrinho(cartaSelecionada);
        }

        return RedirectToAction("Index");
    }
}