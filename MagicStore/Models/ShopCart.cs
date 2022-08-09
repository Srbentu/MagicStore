using MagicStore.Context;
using Microsoft.EntityFrameworkCore;

namespace MagicStore.Models;

public class ShopCart
{
    private readonly AppDbContext _context;

    public ShopCart(AppDbContext context)
    {
        _context = context;
    }


    public string ShopCartId { get; set; }

    public List<ShopCartItem> ShopCartItems { get; set; }

    public static ShopCart GetCart(IServiceProvider services)
    {
        //Define uma sessão
        ISession session =
            services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

        //Obtem um serviço do tipo do nosso contexto
        var context = services.GetService<AppDbContext>();

        //Obtem ou gera o ID do carrinho
        string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

        //Atribui o id do carrinho na Sessão
        session.SetString("CartId", cartId);

        //Retorna o carrino com o contexto e o Id atribuido ou obtido
        return new ShopCart(context)
        {
            ShopCartId = cartId
        };
    }

    public void AddCart(Card card)
    {
        var cartShopItem = _context.ShopCartItens.SingleOrDefault(
            s => s.Card.CardId == card.CardId &&
                 s.ShopCartId == ShopCartId);
        if (cartShopItem == null)
        {
            cartShopItem = new ShopCartItem()
            {
                ShopCartId = ShopCartId,
                Card = card,
                Amount = 1
            };
            _context.ShopCartItens.Add(cartShopItem);
        }
        else
        {
            cartShopItem.Amount++;
        }

        _context.SaveChanges();
    }

    public int RemoveCart(Card card)
    {
        var cartShopItem = _context.ShopCartItens.SingleOrDefault(
            s => s.Card.CardId == card.CardId &&
                 s.ShopCartId == ShopCartId);

        var LocalAmount = 0;

        if (cartShopItem != null)
        {
            if (cartShopItem.Amount > 1)
            {
                cartShopItem.Amount--;
                LocalAmount = cartShopItem.Amount;
            }
            else
            {
                _context.ShopCartItens.Remove(cartShopItem);
            }
        }

        _context.SaveChanges();
        return LocalAmount;

    }
    
    public List<ShopCartItem> GetShopCartItems()
    {
        return ShopCartItems ?? 
               (ShopCartItems = 
                   _context.ShopCartItens
                       .Where(c => c.ShopCartId == ShopCartId)
                       .Include(s => s.Card)
                       .ToList());
    }

    public void CleanCart()
    {
        var CartItens = _context.ShopCartItens
            .Where(cart => cart.ShopCartId == ShopCartId);
        _context.ShopCartItens.RemoveRange(CartItens);
        _context.SaveChanges();
    }

    public decimal GetCartTotal()
    {
        var total = _context.ShopCartItens
            .Where(c => c.ShopCartId == ShopCartId)
            .Select(c => c.Card.CardPrice * c.Amount).Sum();
        return total;
    }
}