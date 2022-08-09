using MagicStore.Context;
using Microsoft.EntityFrameworkCore;

namespace MagicStore.Models;

public class CarrinhoCompra
{
    private readonly AppDbContext _context;

    public CarrinhoCompra(AppDbContext context)
    {
        _context = context;
    }


    public string CarrinhoCompraId { get; set; }

    public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

    public static CarrinhoCompra GetCarrinho(IServiceProvider services)
    {
        //Define uma sessão
        ISession session =
            services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

        //Obtem um serviço do tipo do nosso contexto
        var context = services.GetService<AppDbContext>();

        //Obtem ou gera o ID do carrinho
        string carrinhoId = session.GetString("CartaId") ?? Guid.NewGuid().ToString();

        //Atribui o id do carrinho na Sessão
        session.SetString("CarrinhoId", carrinhoId);

        //Retorna o carrino com o contexto e o Id atribuido ou obtido
        return new CarrinhoCompra(context)
        {
            CarrinhoCompraId = carrinhoId
        };
    }

    public void AdicionarAoCarrinho(Carta carta)
    {
        var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
            s => s.Carta.CartaId == carta.CartaId &&
                 s.CarrinhoCompraId == CarrinhoCompraId);
        if (carrinhoCompraItem == null)
        {
            carrinhoCompraItem = new CarrinhoCompraItem()
            {
                CarrinhoCompraId = CarrinhoCompraId,
                Carta = carta,
                Quantidade = 1
            };
            _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
        }
        else
        {
            carrinhoCompraItem.Quantidade++;
        }

        _context.SaveChanges();
    }

    public int RemoverDoCarrinho(Carta Carta)
    {
        var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
            s => s.Carta.CartaId == Carta.CartaId &&
                 s.CarrinhoCompraId == CarrinhoCompraId);

        var quantidadeLocal = 0;

        if (carrinhoCompraItem != null)
        {
            if (carrinhoCompraItem.Quantidade > 1)
            {
                carrinhoCompraItem.Quantidade--;
                quantidadeLocal = carrinhoCompraItem.Quantidade;
            }
            else
            {
                _context.CarrinhoCompraItens.Remove(carrinhoCompraItem);
            }
        }

        _context.SaveChanges();
        return quantidadeLocal;

    }
    
    public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
    {
        return CarrinhoCompraItems ?? 
               (CarrinhoCompraItems = 
                   _context.CarrinhoCompraItens
                       .Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
                       .Include(s => s.Carta)
                       .ToList());
    }

    public void CleanCart()
    {
        var carrinhoItens = _context.CarrinhoCompraItens
            .Where(carrinho => carrinho.CarrinhoCompraId == CarrinhoCompraId);
        _context.CarrinhoCompraItens.RemoveRange(carrinhoItens);
        _context.SaveChanges();
    }

    public decimal GetCarrinhoCompraTotal()
    {
        var total = _context.CarrinhoCompraItens
            .Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
            .Select(c => c.Carta.Preco * c.Quantidade).Sum();
        return total;
    }
}