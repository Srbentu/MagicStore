using MagicStore.Models;
using MagicStore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MagicStore.Controllers;

public class PedidoController : Controller
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly CarrinhoCompra _carrinhoCompra;

    public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
    {
        _pedidoRepository = pedidoRepository;
        _carrinhoCompra = carrinhoCompra;
    }
    [HttpGet]
    public IActionResult Checkout()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Checkout(Pedido pedido)
    {
        int totalItensPedido = 0;
        decimal precoTotalPedido = 0.0m;
        
        //obtem os itens do carrinho de compra do cliente
        List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItens();
        _carrinhoCompra.CarrinhoCompraItems = items;
        
        //verificar se existem itens de pedido
        if (_carrinhoCompra.CarrinhoCompraItems.Count == 0)
        {
            ModelState.AddModelError("","Carrinho vazio, adiciona um produto");
        }
        //calcula o total de itens e do pedido
        foreach (var item in items)
        {
            totalItensPedido += item.Quantidade;
            precoTotalPedido += (item.Carta.Preco * item.Quantidade);
        }
        
        //atribui os valores obidos ao pedido
        pedido.TotalItensPedido = totalItensPedido;
        pedido.PedidoTotal = precoTotalPedido;
        
        //validar os dados do pedido
        if (ModelState.IsValid)
        {
            //criar pedido e detalhes
            _pedidoRepository.CriarPedido(pedido);
            
            //define mensagens ao cliente
            ViewBag.CheckoutCompletoMensagem = "Obrigado pelo Pedido :)";
            ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();
            
            //limpar carrinho
            _carrinhoCompra.LimparCarrinho();
            
            //exibe a view com dados do cliente e pedido
            return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
        }

        return View(pedido);
    }
}